using HtmlAgilityPack;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Aplicacao.Settings;
using Promessometro.Dominio.Requerimentos;
using Promessometro.Dominio.Vereadores;
using Promessometro.Dominio.Votos;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using UglyToad.PdfPig;

namespace Promessometro.WebScraping.CamaraSjc;

internal class ExtratorDeVotacao(
    IVereadorRepository vereadorRepository,
    IHttpClientFactory httpClientFactory,
    WebScrappingSettings webScrappingSettings) : IExtratorDeVotacao
{
    private List<Vereador> vereadores = [];
    public async Task<List<Requerimento>> BuscarRequerimentosComVotacoesAsync()
    {
        vereadores = await vereadorRepository.GetAllAsync();
        return await FiltrarArquivosEmCadaDiaEProcessarPdfs();
    }

    private async Task<List<Requerimento>> FiltrarArquivosEmCadaDiaEProcessarPdfs()
    {
        List<Requerimento> requerimentos = [];
        var dataDeFiltroInicial = DateTime.Now.Date.AddDays(-webScrappingSettings.PeriodoDeBuscaEmDias);
        while(dataDeFiltroInicial <= DateTime.Now.Date)
        {
            var client = httpClientFactory.CreateClient();
            var url = RetornaUrl(dataDeFiltroInicial);
            var html = await client.GetStringAsync(url);
            var htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(html);
            var requerimentosProcessados = await BuscarArquivos(htmlDoc);
            requerimentos.AddRange(requerimentosProcessados);
            dataDeFiltroInicial = dataDeFiltroInicial.AddDays(1);
        }
        return requerimentos;
    }

    private async Task<List<Requerimento>> BuscarArquivos(HtmlDocument htmlDoc)
    {
        List<Requerimento> requerimentos = [];
        var arquivos = htmlDoc.DocumentNode
            .SelectNodes("//a[contains(@href, '.pdf')]");

        if (arquivos == null)
        {
            return [];
        }

        foreach (var arquivo in arquivos)
        {
            string href = arquivo.GetAttributeValue("href", "");
            if (href is null)
            {
                continue;
            }
            var pdfUrl = new Uri(href).ToString();
            var requerimentosProcessados = await ProcessarPdf(pdfUrl);
            requerimentos.AddRange(requerimentosProcessados);
        }
        return requerimentos;
    }

    private async Task<List<Requerimento>> ProcessarPdf(string pdfUrl)
    {
        List<Requerimento> requerimentos = [];
        var client = httpClientFactory.CreateClient();
        var data = await client.GetByteArrayAsync(pdfUrl);
        using var ms = new MemoryStream(data);
        using var pdf = PdfDocument.Open(ms);
        
        var text = string.Join("\n", pdf.GetPages().Select(p => p.Text));
        if (text is null)
        {
            return [];
        }

        var blocoPattern = new Regex(
            @"Requerimento\s+n[º°]?\s*(\d+/\d{4}).*?Resultado:\s*(Aprovado|Aprovada|Rejeitada|Rejeitado)(.*?)(?=\d+\))",
            RegexOptions.Singleline | RegexOptions.IgnoreCase);

        foreach (Match m in blocoPattern.Matches(text))
        {
            var requerimento = ProcessaDadosRequerimento(m);
            requerimentos.Add(requerimento);
        }
        return requerimentos;
    }

    private Requerimento ProcessaDadosRequerimento(Match m)
    {
        var codigo = m.Groups[1].Value.Trim();
        var aprovado = m.Groups[2].Value.StartsWith("Aprovad", StringComparison.OrdinalIgnoreCase);
        var votesSection = m.Groups[3].Value;

        var requerimento = Requerimento.Create(codigo, aprovado);

        var votoPattern = new Regex(@"([\p{L}\s\.]+?)\s+(Favorável|Contrário)", RegexOptions.IgnoreCase);

        foreach (Match v in votoPattern.Matches(votesSection))
        {
            var nomeVereador = v.Groups[1].Value.Trim();
            var foiFavoravel = v.Groups[2].Value.Equals("Favorável", StringComparison.OrdinalIgnoreCase);
            var vereador = vereadores
                .FirstOrDefault(v => RemoverAcentos(v.Nome) == RemoverAcentos(nomeVereador));

            if (vereador is null)
            {
                continue;
            }

            var voto = Voto.Create(requerimento.Id, vereador.Id, foiFavoravel);
            requerimento.Votos.Add(voto);
        }

        return requerimento;
    }

    private static string RemoverAcentos(string texto)
    {
        return new string(texto
        .Normalize(NormalizationForm.FormD)
        .Where(c => CharUnicodeInfo.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark)
        .ToArray())
        .ToLower();
    }

    private string RetornaUrl(DateTime dataFiltro)
    {
        var dia = dataFiltro.Day;
        var mes = dataFiltro.Month;
        var ano = dataFiltro.Year;
        return string.Concat(webScrappingSettings.Url, $"?dt_ini={dia}-{mes}-{ano}&dt_fim={dia}-{mes}-{ano}");
    }
}
