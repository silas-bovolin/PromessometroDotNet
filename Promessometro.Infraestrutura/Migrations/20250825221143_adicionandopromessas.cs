using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Promessometro.Infraestrutura.Migrations
{
    /// <inheritdoc />
    public partial class adicionandopromessas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("8e54ceb0-04ef-41ac-8cc1-e857827ba790"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("0d5c5cea-aea7-44ab-93e7-3b93b284839a"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("1e918a99-36d5-4d37-b862-eddb4909575b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2792b548-f56a-4df8-a10d-c74136104b29"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("2a763dee-a189-410f-91d3-08274608cc2c"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("46b7b815-4dc4-4b04-9943-4e15cb69a3a3"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("47f336a2-05d6-43e0-9d54-9ca34d79fcdf"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("4a09d1c3-90e4-4afa-a8b8-18f4a451cec6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("4ecc62a7-98fe-40d8-a064-bd40a3eebac1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("613f5f6d-8e5c-43c7-be78-6c5981f65ad1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("8cf43309-6ea6-45fb-8cfd-fa12412ed917"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91243476-d9c0-40bd-a071-aae33fb24f9d"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91831de7-6806-4939-9385-5861808b9349"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a2ebdaee-25ef-448e-8829-76b9ef6c20f2"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a2f79f19-a026-46fd-9e6c-70fc8e696979"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("b38e8455-1d46-490d-9045-60e47b2ed1cb"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c19328e6-5083-40aa-addd-0e5403d1ba15"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c7371ee0-c96a-454b-9770-2488b177c782"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c82016c8-1527-4516-a1af-e8007e55fe36"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("e41797cc-97bb-467f-b864-632bd495c43f"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("f43b2d58-49f1-4dbd-b869-57296870a266"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("fb1109d2-a13b-423e-bf97-a58ad8bd5c88"));

            migrationBuilder.InsertData(
                table: "Promessas",
                columns: new[] { "Id", "ConclusaoPorcentagem", "Descricao", "Detalhes", "Titulo" },
                values: new object[,]
                {
                    { new Guid("05b23d71-285f-4102-a6cb-a5d00400522a"), 33, "A Praça Rubens Castilho foi revitalizada, mas não há obras visíveis ou confirmadas nas demais áreas citadas.", "", "Criar novos decks e revitalizar áreas verdes (Via Cambuí, Praça Rubens Castilho, Mirante no Talude da Veibras)." },
                    { new Guid("0617c99b-a07f-43eb-88ef-04266549f11b"), 100, "Incentivar e apoiar delegação joseense nos Jogos Regionais do Idoso (JOMI).", "", "Incentivar participação nos Jogos Regionais do Idoso (JOMI)" },
                    { new Guid("0a20d30b-846a-4671-bc08-63fdbe99d83f"), 0, "Não há registro de ampliação desse programa, apenas a manutenção dos serviços já oferecidos", "", "Ampliar o programa de distribuição gratuita de vacinação de animais contra a brucelose, raiva do rebanho etc" },
                    { new Guid("0bed51e6-dc27-4e9f-a943-4e0ba82dfd34"), 0, "A promessa visa estabelecer uma instituição dedicada à formação e aprimoramento contínuo de profissionais da área da saúde em São José dos Campos, com o objetivo de elevar a qualidade dos serviços prestados à população.", "", "Criar a Escola de Formação em Saúde, um centro de treinamento para qualificar os profissionais da área." },
                    { new Guid("0cfdfceb-e47a-48ee-94d1-96351302645d"), 0, "Fortalecer a Ronda de Apoio Social, 24h, em todas as regiões da cidade.", "", "Ronda de Apoio Social" },
                    { new Guid("0fdd729f-4446-4c29-95a0-c2695444ecdb"), 0, "A promessa consiste na abertura e execução de processos seletivos para o preenchimento de vagas no quadro de servidores da Prefeitura de São José dos Campos, visando a contratação de novos profissionais para diversas áreas da administração pública. Progresso: 75%", "", "Realizar concurso público." },
                    { new Guid("11d1ea67-aa00-4073-8ef0-48944ee364e3"), 100, "Sim, foi ampliado para mais de 1000 vagas por edição, o que é um aumento considerável. Porém, os tutores devem ficar atentos pois as vagas se esgotam muito rápido. Em 2025 já foram realizadas 3 edições de castração e microchipagem diretamente no CCZ.", "", "Ampliar o atendimento gratuito do Meu Pet Feliz, programa permanente de castração e chipagem de animais" },
                    { new Guid("1302c617-1c83-411c-9d6f-66941037bc5c"), 0, "A promessa visa expandir o programa de fornecimento de fraldas, dietas e fórmulas infantis para atender um número maior de pacientes necessitados no município de São José dos Campos. O objetivo é aumentar o acesso a esses itens essenciais para a saúde e bem-estar de crianças e outros pacientes que dependem deles.", "", "Fralda em casa, dietas e fórmulas infantis: ampliar o programa para atendimento de mais pacientes." },
                    { new Guid("1424775e-ae1c-4a5e-a705-fd8a4d62b0a3"), 50, "Implantação do CER III no Bosque dos Eucaliptos (atrás da Casa do Idoso Sul).", "", "Criar o novo CER (Centro Especializado em Reabilitação) na Casa do Idoso Sul" },
                    { new Guid("1828d94a-013a-4fe2-99bc-d9fadbab8fc0"), 0, "Oferecer atendimento psicológico e social online para dar suporte aos", "", "Atendimento psicológico a dependentes químicos" },
                    { new Guid("198e94f1-4f9c-4581-93ff-5d32360bee16"), 100, "São José Social: a exemplo do Programa São José Unida, desenvolver ações", "", "Ações integradas usuários de drogas" },
                    { new Guid("1b4b00d0-4e29-4b4b-bfac-8e1b1b8af04b"), 100, "Oferta regular de cursos de Cuidador de Idosos e correlatos.", "", "Ampliar cursos para cuidadores de idosos" },
                    { new Guid("1dcbd85b-93c0-48c4-bea8-15bdaa24e305"), 10, "Implantação de um novo hospital público na zona sul de São José dos Campos em colaboração com a Santa Casa. O projeto envolve a doação de terreno municipal (antigo prédio do Pró‑Visão) à instituição, que deve construir e operar o hospital, com parte da estrutura atendendo ao SUS e outra parte podendo ser utilizada por atendimentos privados/complementares, além da realocação de uma UBS no complexo", "", "Construir o Novo Hospital da Região Sul, em parceria com a Santa Casa, ampliando o atendimento à população." },
                    { new Guid("1e7f4e02-80a2-4526-8b81-bdf4c23ce033"), 0, "Construir a Nova Unidade do Cras, no Campo dos Alemães.", "", "Cras (Centro de Referência da Assistência Social)" },
                    { new Guid("220570bd-a247-4e91-972c-1bd725514aa8"), 0, "Não há comprovação de que a iluminação nesse trecho da SP-50 foi implantada até o momento.", "", "Implantar nova iluminação na SP-50, do bairro Boa Vista até o Buquirinha 1" },
                    { new Guid("26a4da1e-fc31-46e3-be61-73cf49c3f9db"), 100, "Sim, a prefeitura realiza campanha de adoção todos os meses, sempre no último sábado de cada mês. O local é sempre no CCZ.", "", "Promover campanhas de doação de animais e a posse responsável" },
                    { new Guid("28c37e7f-ff3e-4678-be2d-176c57e19658"), 100, "A meta foi cumprida. 100% da rede pública já utiliza LED, com constante ampliação para áreas verdes, praças e espaços de lazer em todas as regiões.", "", "Manter e ampliar a iluminação de LED em toda área urbana (praças, áreas verdes e ciclovia) e rural." },
                    { new Guid("2b0d4cca-17e0-40b9-96f9-3c2a7d774c1b"), 50, "Houve ampliação do horário de funcionamento e realocação de unidades para melhor atendimento, como no PEV do Campo dos Alemães. Porém, não há expansão significativa em número de unidades.", "", "Ampliar, modernizar e melhorar a gestão dos PEVs" },
                    { new Guid("2c04abc1-b9a4-4643-b09b-50dbff770593"), 0, "A promessa visa expandir a capacidade de testagem e detecção de Infecções Sexualmente Transmissíveis em São José dos Campos, por meio da implementação ou ampliação de um serviço de testagem móvel, facilitando o acesso da população aos exames preventivos.", "", "Ampliar o serviço de testagem de IST (Infecções Sexualmente Transmissíveis) com serviço móvel." },
                    { new Guid("2c6763ed-cef5-4a9c-85a4-8230cc0cbc7f"), 0, "A promessa visa a construção de uma nova Unidade Básica de Saúde (UBS) com o modelo \"Resolve\" no bairro Jardim Primavera, em São José dos Campos. O objetivo é ampliar e melhorar o acesso aos serviços de saúde primária para os moradores da região, oferecendo um atendimento mais completo e eficiente.", "", "Construir a Nova UBS Resolve do Jardim Primavera." },
                    { new Guid("305c9c29-10cf-46cf-b750-07502f55e741"), 10, "Esta promessa de campanha visa a expansão dos serviços oferecidos pelo programa Previna, em São José dos Campos, com o objetivo de assegurar que o diagnóstico e o tratamento de pacientes com câncer sejam realizados em um prazo máximo de 60 dias. A iniciativa busca agilizar o acesso a esses cuidados essenciais.", "", "Ampliar o atendimento no Previna, com o diagnóstico e o tratamento do paciente com câncer em até 60 dias." },
                    { new Guid("31459779-afd6-4ff9-baa2-ce5de7356ee6"), 0, "Não há registro da instalação de borrifadores em praças ou parques da cidade.", "", "Equipar praças e parques com borrifadores para refrescar as crianças e os adultos neste clima de tempo seco" },
                    { new Guid("347dacf9-99cf-4eb7-8535-9be16db91dca"), 0, "A promessa consiste na construção de uma nova Unidade de Pronto Atendimento (UPA) para ampliar e qualificar o atendimento de urgência e emergência aos moradores da Região Norte de São José dos Campos, especificamente no bairro Alto da Ponte ou em suas imediações.", "", "Construir a Nova UPA da Região Norte, no Alto da Ponte." },
                    { new Guid("34af86c4-f4e9-473e-8d16-34b705df1b6f"), 0, "Esta promessa de campanha visa a criação de uma Unidade Avançada de Saúde no bairro Jardim República, em São José dos Campos. O objetivo é expandir o acesso e aprimorar os serviços de saúde para os moradores de uma área específica, incluindo os bairros Vila das Flores, Nova República, Cruzeiro do Sul, Santa Edwiges e adjacências. Essa unidade buscaria oferecer atendimento primário e facilitar o acesso da população local a serviços de saúde essenciais.", "", "Criar a Unidade Avançada de Saúde no Jardim República para atender a região: Vila das Flores, Nova República, Cruzeiro do Sul, Santa Edwiges e adjacências." },
                    { new Guid("366212d2-50af-4f10-974a-7c63174f99c6"), 100, "Criar/estruturar programa com eixos de mente, uso correto de medicamentos, atividades de manutenção e mobilidade.", "", "Programa Envelhecimento Saudável" },
                    { new Guid("369186a3-3e99-48c4-9d9c-820205374134"), 50, "O Jardim Satélite recebeu melhorias em anos anteriores. Vista Verde ainda não apresenta registro recente de intervenções.", "", "Revitalizar as áreas verdes do Vista Verde e Jardim Satélite, com melhoria de iluminação, jardinagem e passeio público." },
                    { new Guid("370cba56-d9df-4603-bc97-a300d5c1bfb4"), 0, "Não há registro de construções de novos espaços caninos até o momento em 2025. Atualmente existem 16 pela cidade.", "", "Construção de novos Espaços Caninos" },
                    { new Guid("3ab3ba9d-6a81-49ea-8fb7-2a86a158db1e"), 0, "Não foram encontrados registros de obras iniciadas ou concluídas nessa área.", "", "Criar um novo deck e urbanizar a área verde da Vila Flores, na região sul, com pista de caminhada, quadra esportiva, bancos e área de lazer para as crianças" },
                    { new Guid("3c335b3b-7a3f-4a9f-849f-aa10c56625e9"), 0, "Criar a Casa da Família Joseense: com a possibilidade de agregar no", "", "Casa da Família Joseense" },
                    { new Guid("3ce209e4-6515-4646-9634-70851a07c8bc"), 100, "Expandir participação e calendário da gincana nas Casas do Idoso.", "", "Ampliar participação dos idosos na Gincana da Maturidade" },
                    { new Guid("41e02f04-5e84-431b-87a3-3469a473c36d"), 0, "Viabilizar a abertura de mais uma unidade do Bom Prato em São José dos", "", "Bom Prato" },
                    { new Guid("44affeb1-b2c9-4e66-a75c-94b140a26c6c"), 0, "A promessa é a instalação de uma nova Unidade Básica de Saúde (UBS) no modelo \"Resolve\" dentro do complexo do Novo Hospital da Região Sul, no bairro Bosque dos Eucaliptos. O objetivo é integrar serviços de saúde primária e secundária, oferecendo um atendimento mais completo e acessível à população.", "", "Instalar a Nova UBS Resolve do Bosque dos Eucaliptos, no Novo Hospital da Região Sul." },
                    { new Guid("46506ecd-e1e6-4fd4-b5ce-64677e423013"), 0, "Viabilizar, com a CDHU/Estado, moradias assistidas para idosos em vulnerabilidade.", "", "Programa Vida Longa (CDHU) — moradias para idosos" },
                    { new Guid("49231416-5c4d-440e-88b5-0d77fa2bd3e9"), 0, "A promessa foca em assegurar a continuidade e impulsionar programas de aprimoramento profissional e educacional para docentes e gestores da rede de ensino de São José dos Campos, visando a melhoria da qualidade da educação.", "", "Manter e estimular as atividades de formação continuada para professores e gestores." },
                    { new Guid("492e1fd6-4b9b-4942-bda9-cc4bb4bc0457"), 50, "Criar um programa focado em renda e qualificação para pessoas idosas.", "", "Qualifica o Idoso — programa de geração de renda e capacitação" },
                    { new Guid("4bd2985b-467e-4de9-ba4f-a6afce5cee59"), 0, "A promessa visa aumentar o número de profissionais de saúde, especificamente médicos e enfermeiros, na rede pública de São José dos Campos para melhorar o atendimento à população.", "", "Contratar mais médicos e enfermeiros." },
                    { new Guid("58d4fff7-10ab-40c4-b3aa-1ce38069127e"), 25, "Finalizar a construção da Unidade Básica de Saúde no modelo UBS Resolve, localizada na Vila Industrial (Rua Mizael Marçal), com estrutura moderna e atendimento ambulatorial integrado, conforme previsão de conclusão no mandato iniciado em 1º de janeiro de 2025.", "", "Construir a Nova UBS Resolve da Vila Industrial." },
                    { new Guid("5d609876-79c6-4fc5-9a17-ba87915672be"), 0, "Finalizar a expansão do Hospital de Clínicas Sul, localizado no Parque Industrial de São José dos Campos, incluindo a criação de 82 novos leitos e salas de cirurgia, com o objetivo de aumentar a capacidade de atendimento hospitalar e cirúrgico da região.", "", "Concluir a ampliação do Hospital de Clínicas Sul, no Parque Industrial, com mais 82 leitos e salas de cirurgia." },
                    { new Guid("5e25fb6d-ea54-4b83-8a58-3a5e9996989b"), 100, "Consolidar as parcerias com as entidades sociais e com o Fundo Social de", "", "Parcerias com o Fundo Social de Solidariedade e entidades sociais" },
                    { new Guid("6182086a-1b14-4255-b097-1bea18ce8fc0"), 50, "Contêineres metálicos grandes foram instalados no centro da cidade, em pontos com alta geração de resíduos. Não houve expansão para bairros.", "", "Coleta com containers em pontos de alta concentração de resíduos" },
                    { new Guid("61d7b778-176d-4ca7-9e65-2be2e4a25505"), 0, "Fortalecer e intensificar o Programa “Não Dê Esmola, Dê Cidadania”.", "", "Programa “Não Dê Esmola, Dê Cidadania”" },
                    { new Guid("6b9ad635-d16a-41b4-af51-482b6dd8e629"), 0, "Não há registro de instalação de um PEV específico na região do Cajuru até o momento. A lista oficial de PEVs da cidade não inclui essa localidade.", "", "Instalar um PEV (Ponto de Entrega Voluntária) na região do Cajuru" },
                    { new Guid("70d7e5c6-e96f-468d-a2da-c7bf38b4a846"), 5, "Implantar e integrar um sistema municipal de prontuário eletrônico do paciente para registrar e consolidar históricos médicos e exames em formato digital e unificado, facilitando o acesso e gestão na rede de saúde municipal.", "", "Prontuário eletrônico: consolidar o sistema de informações do histórico do paciente e exames." },
                    { new Guid("71f52d8a-8587-4478-9ce8-1a7799c28bd0"), 50, "A promessa visa garantir a continuidade da presença e do trabalho de psicólogos e assistentes sociais nas unidades escolares de São José dos Campos, oferecendo suporte psicossocial e assistência social aos alunos e à comunidade escolar.", "", "Manter o atendimento de psicólogos e assistentes sociais nas escolas." },
                    { new Guid("7501540c-d555-4d0d-8518-c953dc829246"), 0, "Implantação de uma nova Unidade Básica de Saúde no modelo \"UBS Resolve\", no bairro Pinheirinho dos Palmares, com foco em atendimento integrado, coleta de exames, acolhimento humanizado e infraestrutura moderna para atender à população da região sudeste.", "", "Construir a Nova UBS Resolve do Pinheirinho dos Palmares, na região sudeste." },
                    { new Guid("75e87c60-9680-48f1-b0ba-38c23bc42cc4"), 0, "A cidade ampliou a iluminação em diversas ciclovias, mas não há confirmação específica de que essa ciclovia recebeu nova iluminação.", "", "Melhorar a iluminação da ciclovia na avenida Altos do Rio Doce, no Altos de Santana, beirando o Rio Paraíba" },
                    { new Guid("7f5c39b6-922e-4cf4-bf14-d74453bf403e"), 5, "A promessa tem como objetivo expandir a oferta e a capacidade dos serviços de saúde prestados remotamente por meio da telemedicina em São José dos Campos, visando facilitar o acesso da população a consultas e atendimentos médicos.", "", "Ampliar o atendimento de telemedicina." },
                    { new Guid("7f9118da-393d-400c-96a1-d86e5c95196c"), 50, "Ampliar a entrega domiciliar de fraldas, dietas e fórmulas a pacientes elegíveis.", "", "Fralda em casa; dietas e fórmulas — ampliar programa" },
                    { new Guid("7fff3ebc-926e-47b2-bac9-fd7f8f92eef1"), 100, "Ampliar o atendimento domiciliar (saúde e assistência) a idosos com dificuldades de locomoção.", "", "Ampliar o atendimento domiciliar aos idosos" },
                    { new Guid("8060d2eb-e417-441e-bbeb-eceb551ddc9c"), 0, "A promessa visa expandir a capacidade de testagem e detecção de Infecções Sexualmente Transmissíveis em São José dos Campos, por meio da implementação ou ampliação de um serviço de testagem móvel, facilitando o acesso da população aos exames preventivos.", "", "Ampliar o serviço de testagem de IST (Infecções Sexualmente Transmissíveis) com serviço móvel." },
                    { new Guid("8336bb8f-d2f6-4871-9616-9f4ec39ef4e2"), 50, "A promessa consiste na construção de um novo centro especializado para reabilitação motora e neurológica, com o objetivo de concentrar os serviços de atendimento e expandir a capacidade de cuidado aos pacientes que necessitam desses tratamentos em São José dos Campos.", "", "Criar o Novo Centro de Reabilitação Motora e Neurológica, para centralizar e ampliar o atendimento aos pacientes." },
                    { new Guid("86fc9f31-3477-4613-9e64-73ffb85c8428"), 0, "A promessa tem como objetivo aumentar a capacidade e a qualidade dos serviços de saúde mental oferecidos nos hospitais Francisca Júlia e Chuí, proporcionando um atendimento mais abrangente e especializado para a população de São José dos Campos.", "", "Ampliar o atendimento especializado de Saúde Mental, nos hospitais Francisca Júlia e Chuí." },
                    { new Guid("89a2156e-d446-4108-b26f-97eda6eb00dd"), 0, "A promessa prevê a expansão do serviço de Motolância em São José dos Campos, buscando otimizar o tempo de resposta em atendimentos de emergência. Isso seria alcançado por meio de uma parceria entre a Prefeitura, o Corpo de Bombeiros e o Samu, visando aprimorar a agilidade e a eficácia no socorro a pacientes.", "", "Motolância: ampliar o atendimento aos pacientes, numa parceria da Prefeitura/Corpo de Bombeiros/Samu." },
                    { new Guid("8b71c2c2-3e64-4973-a7ac-b7bee2563862"), 0, "Ampliar as vagas de internação para o tratamento da dependência química.", "", "Aumentar vagas de internação" },
                    { new Guid("9013e776-dc48-47b6-9e14-2a790806605c"), 30, "Foi implantado projeto piloto no centro da cidade (Rua Siqueira Campos e Praça João Mendes). Porém, não houve expansão para outras regiões.", "", "Ampliar o sistema de lixeiras subterrâneas para coleta em pontos de grande concentração de resíduos" },
                    { new Guid("90dda066-9bc7-4e5c-bb53-a5ed23c90a30"), 100, "Fortalecer o Peti (Programa de Erradicação do Trabalho Infantil),", "", "Peti (Programa de Erradicação do Trabalho Infantil)" },
                    { new Guid("94efbe12-510d-4197-829e-73d501bddc3b"), 20, "A promessa visa aumentar o número e a capacidade das equipes de Saúde da Família em São José dos Campos, com o objetivo de fortalecer a atenção primária e ampliar a cobertura do atendimento de saúde para a população.", "", "Ampliar as Equipes de Saúde da Família." },
                    { new Guid("951f9d3d-f47b-43d9-aa38-b5fe43984175"), 5, "Realizar concursos públicos e/ou processos seletivos para contratação efetiva de professores e agentes educadores na rede municipal de ensino, com o objetivo de fortalecer a educação pública com quadro estabilizado e adequado às demandas escolares atuais.", "", "Realizar concurso público para contratar mais professores e agentes educadores." },
                    { new Guid("9769aedf-c0db-4559-833a-be078a5c8f7b"), 0, "Não há informações oficiais ou evidências públicas de obras de manutenção ou melhorias em estradas rurais nos anos recentes.", "", "Fazer manutenção e melhorias nas estradas rurais" },
                    { new Guid("97f84802-cbe5-447b-8615-61504b6c1bf5"), 50, "Revitalização/reformas para melhorar o bem-estar de residentes em ILPIs.", "", "Revitalizar e reformar ILPIs (Instituições de Longa Permanência)" },
                    { new Guid("9853af84-c3fc-4347-ac6a-8f6acc914a11"), 0, "A promessa tem como objetivo implementar um programa para a entrega de medicamentos de alto custo e de uso contínuo diretamente na residência dos pacientes em São José dos Campos, visando facilitar o acesso e a adesão ao tratamento, especialmente para aqueles com dificuldades de locomoção ou que dependem de medicações específicas.", "", "Medicação em casa: entrega de medicamentos de alto custo e uso crônico na casa dos pacientes." },
                    { new Guid("9c102965-685c-42ff-803f-7564c889d1fe"), 75, "Esta promessa de campanha foca na gestão financeira e de recursos humanos da prefeitura, garantindo o pagamento pontual dos salários dos servidores públicos e a manutenção do gatilho salarial, que assegura reajustes automáticos conforme determinados indicadores de inflação.", "", "Manter os salários em dia e o gatilho salarial do servidor." },
                    { new Guid("9d70d2ac-30ed-472c-a380-b35a582fed69"), 5, "Implantação de uma nova UBS Resolve no bairro Cajuru, com estrutura física moderna, atendimento ambulatorial integrado, exames e acolhimento humanizado, conforme diretrizes do modelo UBS Resolve.", "", "Construir a Nova UBS Resolve na região do Cajuru." },
                    { new Guid("a1e621fe-d458-469f-9735-eb43a3f08122"), 100, "A proposta prevê a continuidade do benefício de bolsa de estudos para servidores municipais, com análise e concessão de bolsas educacionais ou acadêmicas destinadas aos servidores e seus dependentes, conforme critérios estabelecidos pela Prefeitura.", "", "Manter o programa de bolsa de estudos para os servidores." },
                    { new Guid("a337263e-1a73-4d89-94d9-1cb9d8fca4e3"), 0, "A promessa visa atualizar e aprimorar o aplicativo \"Saúde na Mão\" de São José dos Campos, incorporando novas funcionalidades e serviços para torná-lo mais útil e intuitivo, facilitando o acesso dos usuários a informações e atendimentos de saúde.", "", "Saúde na Mão: modernizar o aplicativo para oferecer mais serviços e facilitar a vida dos usuários." },
                    { new Guid("a99e12f5-90a0-429d-8933-6dae30e6550a"), 50, "Organizar o registro e integrar serviços (saúde, assistência, esporte e cultura) voltados para o idoso.", "", "Registro, integração e ampliação dos serviços para o idoso" },
                    { new Guid("ab025ed4-8dcb-4dc9-950f-5c7f4a82cd00"), 0, "Construção de uma nova unidade da Casa do Idoso na região sul.", "", "Construir mais uma Casa do Idoso na região sul" },
                    { new Guid("ab6d3972-550e-40f5-b33d-f0a6b694fc76"), 0, "Construção não iniciada, porém já existe lei sancionada no Diário Oficial pra essa finalidade, restando agora liberação de recursos orçamentários para a obra.", "", "Contrução do novo CCZ (Centro de Controle de Zoonozes)" },
                    { new Guid("acaf5846-4523-4d0d-afce-ed7cf3dd1847"), 0, "Não há confirmação de substituição das lixeiras convencionais por contêineres na zona rural até o momento.", "", "Melhorar a coleta de lixo na zona rural, substituindo as lixeiras por contêineres" },
                    { new Guid("b32613fe-a528-4ee9-a156-5825a8514d79"), 0, "Não há registro dessas campanhas no ano de 2025 até o momento. A última ocorreu em abril de 2024", "", "Promover campanha de adoção de animais de médio e grande porte" },
                    { new Guid("b4c9444d-de46-4c9f-9029-2c1c7fe4885c"), 0, "Fazer acompanhamento social e promover oficinas de capacitação", "", "Capacitação para moradores de conjuntos habitacionais" },
                    { new Guid("c0c11de4-7fbe-493a-a2e5-8d72b0a912ce"), 0, "Ampliação do PREVINA para diagnóstico e tratamento de Alzheimer e outras demências.", "", "Ampliar atendimento no PREVINA com foco em Alzheimer/demências" },
                    { new Guid("c54ae230-6f1a-44cf-b3ea-7b1611a0962f"), 0, "Esta promessa de campanha tem como objetivo expandir a oferta de consultas com especialistas e exames para a população de São José dos Campos, através do ampliação do credenciamento de clínicas particulares pelo poder público.", "", "Ampliar o credenciamento de clínicas particulares para oferecer mais consultas com especialistas e exames." },
                    { new Guid("c599221b-2267-404e-840e-513bbee28062"), 0, "A promessa de campanha visa assegurar a distribuição de cestas de alimentos, ou um benefício equivalente, para a população de São José dos Campos durante o período natalino. O objetivo é proporcionar apoio alimentar às famílias em vulnerabilidade social no final do ano.", "", "Garantir a cesta de Natal." },
                    { new Guid("c74d2a4f-c6c1-4531-9b22-7b0e6c300137"), 0, "Implantar uma Unidade Básica de Saúde no modelo “UBS Resolve” no bairro Jardim Santa Hermínia, oferecendo atendimento ambulatorial integrado, coleta de exames, acolhimento humanizado e estrutura moderna para facilitar o acesso à saúde da população local.", "", "Construir a Nova UBS Resolve do Jardim Santa Hermínia." },
                    { new Guid("cb26cdbb-2010-489b-ac98-52854ba8f7f4"), 25, "A promessa visa expandir a capacidade de atendimento do Serviço de Atendimento Móvel de Urgência (Samu) em São José dos Campos, o que pode envolver o aumento da frota de veículos, a contratação de mais profissionais, a melhoria da infraestrutura ou a otimização dos processos para cobrir uma área maior ou atender mais ocorrências com maior agilidade.", "", "Ampliar o atendimento do Samu." },
                    { new Guid("cb97679d-e3b5-4949-98bb-48b62d60da1e"), 50, "Entregar medicamentos em domicílio mediante critérios de saúde.", "", "Medicamentos em Casa — entrega domiciliar" },
                    { new Guid("cbeeaf8c-e41b-44fb-92bd-cf2dc8d39c1d"), 100, "Implantar melhorias na unidade do Sul e reativar o serviço na Leste.", "", "Melhorias no Centro Dia (Sul) e reativar Centro Dia (Leste)" },
                    { new Guid("cc259c28-03ba-4645-9821-10ec08d97a6e"), 10, "Esta promessa de campanha tem como objetivo a criação de um Novo Centro de Especialidades Odontológicas em São José dos Campos. A iniciativa visa expandir e aprimorar os serviços odontológicos especializados oferecidos à população. A promessa faz parte das diretrizes do Plano de Governo sob \"Saúde\" para o ano de 2026, conforme a Lei de Diretrizes Orçamentárias (LDO) 2026.", "", "Criar o Novo Centro de Especialidades Odontológicas." },
                    { new Guid("dc915010-0eab-4bd9-a290-23a40ebd739e"), 0, "Esta promessa de campanha visa o estabelecimento de um Hub de Inovação em Saúde em São José dos Campos, localizado no Parque de Inovação Tecnológica (PIT). O objetivo é centralizar e fomentar o desenvolvimento de startups focadas em saúde digital e inteligência artificial.", "", "Criar um Hub de Inovação em Saúde, reunindo startups de saúde digital e IA (Inteligência Artificial), no PIT." },
                    { new Guid("e05aa6a0-e952-4b8f-8fbf-a64f2f461382"), 100, "A promessa visa assegurar a continuidade e o aprimoramento constante do treinamento da Guarda Civil Municipal (GCM) de São José dos Campos, utilizando a estrutura da academia de formação para garantir a qualificação e atualização dos profissionais.", "", "Manter o treinamento contínuo dos GCMs por meio da academia de formação." },
                    { new Guid("e0c7f1c2-7fed-40ff-a7e2-6eecafb16602"), 25, "Esta promessa de campanha visa fortalecer o quadro de profissionais da saúde no município de São José dos Campos, por meio da realização de um concurso público específico para a contratação de médicos e enfermeiros, com o intuito de aprimorar os serviços de saúde oferecidos à população.", "", "Realizar concurso público para contratar mais médicos e enfermeiros." },
                    { new Guid("e22643bf-1a13-4130-8f02-560a0d4f84f7"), 0, "Criar a Casa de Passagem para pessoa em situação de rua", "", "Casa de Passagem" },
                    { new Guid("e5386b3d-cbea-499c-8557-56861a96e428"), 0, "Criar um centro especializado de qualificação para idosos.", "", "Implantar um Centro de Qualificação do Idoso" },
                    { new Guid("e7a29819-f199-4546-98d3-9379b1a3391e"), 0, "Não há registro público ou anúncio oficial de caminhões elétricos em operação no sistema de coleta urbana de São José dos Campos", "", "Ampliar a implantação de caminhões elétricos para a coleta de lixo" },
                    { new Guid("e7c89034-8ecf-4162-b8f8-95a2cef0901d"), 70, "Diversas praças e parquinhos receberam piso emborrachado e novos brinquedos, mas ainda não há menção clara sobre brinquedos inclusivos em larga escala.", "", "Ampliar a modernização dos parques infantis com novos brinquedos, brinquedos inclusivos e piso de borracha" },
                    { new Guid("ebae5e19-b4bf-43ab-be91-68ae3a09958a"), 0, "Não há registro de revitalização das fontes nessas áreas, apenas intervenções relacionadas a lixeiras subterrâneas.", "", "Revitalizar as fontes na região central, Praça João Mendes (Praça do Sapo) e ao lado da Univap." },
                    { new Guid("f004a1ca-a1a7-4fb9-a001-8541a408afe7"), 0, "A construção ainda não foi iniciada, o que existe é um convênio da prefeitura com uma empressa limitado a quem é cadastrado no Cad Único", "", "Construir Hospital Público Veterinário" },
                    { new Guid("f18cae55-3f16-48ac-8852-74652e5a500a"), 30, "A promessa tem por objetivo assegurar que o IPSM continue com sua saúde fiscal, realizando os aportes necessários e mantendo em dia o pagamento de aposentadorias e pensões dos servidores municipais, de forma regular e tempestiva.", "", "Manter as contas do IPSM (Instituto de Previdência do Servidor Municipal) em dia, garantindo as aposentadorias e pensões." },
                    { new Guid("faa2918b-ef88-4acd-9a3d-2e1350f6e284"), 5, "Implantação de um centro de diagnóstico por imagem (tomografia e ressonância magnética) no Hospital de Clínicas Sul, em cooperação técnica e financeira com o Governo do Estado, visando a ampliação da capacidade de exames de média e alta complexidade.", "", "Implantar o Centro de Imagens do Hospital de Clínicas Sul, em parceria com o Governo do Estado de São Paulo." },
                    { new Guid("faeee589-c351-4c12-a786-28c34d3c1d60"), 10, "Esta promessa de campanha visa a criação de uma Unidade Avançada de Saúde no bairro Urbanova, em São José dos Campos. A particularidade dessa unidade é a sua implementação em parceria com a Universidade do Vale do Paraíba (Univap), visando integrar serviços de saúde e possivelmente a expertise acadêmica e de pesquisa da instituição. O intuito é expandir e qualificar o atendimento de saúde para os moradores da região do Urbanova.", "", "Criar a Unidade Avançada de Saúde no Urbanova, em parceria com a Univap." }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AceitouOsTermos", "Email", "Nome", "SenhaCriptografada", "Telefone" },
                values: new object[] { new Guid("32ec5321-5b2b-4dfe-992b-b9748d035e82"), true, "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==", "" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("15699966-86d5-4d82-9ead-3b1b649145bc"), "marcaodaacademia.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("181aa82a-2bc3-489d-b0e1-cb052e540552"), "sergiocamargo.jpg", "Sérgio Camargo", "PL" },
                    { new Guid("1e2e0c25-7e51-479a-b672-0bb7f0b24605"), "fernandopetiti.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("23e1cfe8-3b5d-48fd-83c0-d15aa8621a70"), "senna.jpg", "Senna", "PL" },
                    { new Guid("35252558-5c54-40c2-8054-9b7e5e19acd7"), "fabiaozagueiro.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("35d94842-8122-471d-99d5-96d297db4e4b"), "robertodoeleven.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("3908a6b3-51e9-48e8-b433-caea24dd12a6"), "gilsoncampos.jpg", "Gilson Campos", "PRD" },
                    { new Guid("3915ca1b-78d2-49fe-85d7-8223c73e744c"), "julianafraga.jpg", "Juliana Fraga", "PT" },
                    { new Guid("4890165d-36ed-4165-b2db-80847e6f8af1"), "marcelogarcia.jpg", "Marcelo Garcia", "PRD" },
                    { new Guid("5540a4e3-064e-4d83-84d8-6d23f129e637"), "carlosabranches.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("5b4c7b49-e707-4050-810c-a72bfcb53949"), "linobispo.jpg", "Lino Bispo", "PL" },
                    { new Guid("8d7f5027-6aa1-4192-9c8c-2aa2ecd1dab6"), "renatosantiago.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("91aa8f43-adb8-4327-965d-29d52a6f5720"), "amelianaomi.jpg", "Amélia Naomi", "PT" },
                    { new Guid("a16e9e8f-4c53-4cf9-9976-a3f8140e863b"), "rogeriodaacasem.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("acac26a9-0ed8-41a3-b1be-a757115d9e7e"), "miltonvieirafilho.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("beb9ce2a-2c86-4046-b4e5-6e407a042270"), "rafaelpascucci.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("c524c2e9-ed7f-4fca-a1e5-c866ee967c0a"), "thomazhenrique.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("ceeb2582-610c-44d1-8618-3e10043a7f27"), "claudioapolinario.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("e146f7b3-9fb6-4cbf-9173-4911a7daa122"), "robertochagas.jpg", "Roberto Chagas", "PL" },
                    { new Guid("f15fc27b-dc67-417d-afdb-db2922c336a2"), "zeluis.jpg", "Zé Luís", "PSD" },
                    { new Guid("fc132ac6-609f-48f6-b302-8d910e0fbb9f"), "sidneycampos.jpg", "Sidney Campos", "PSDB" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("05b23d71-285f-4102-a6cb-a5d00400522a"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("0617c99b-a07f-43eb-88ef-04266549f11b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("0a20d30b-846a-4671-bc08-63fdbe99d83f"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("0bed51e6-dc27-4e9f-a943-4e0ba82dfd34"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("0cfdfceb-e47a-48ee-94d1-96351302645d"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("0fdd729f-4446-4c29-95a0-c2695444ecdb"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("11d1ea67-aa00-4073-8ef0-48944ee364e3"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1302c617-1c83-411c-9d6f-66941037bc5c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1424775e-ae1c-4a5e-a705-fd8a4d62b0a3"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1828d94a-013a-4fe2-99bc-d9fadbab8fc0"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("198e94f1-4f9c-4581-93ff-5d32360bee16"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1b4b00d0-4e29-4b4b-bfac-8e1b1b8af04b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1dcbd85b-93c0-48c4-bea8-15bdaa24e305"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("1e7f4e02-80a2-4526-8b81-bdf4c23ce033"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("220570bd-a247-4e91-972c-1bd725514aa8"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("26a4da1e-fc31-46e3-be61-73cf49c3f9db"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("28c37e7f-ff3e-4678-be2d-176c57e19658"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("2b0d4cca-17e0-40b9-96f9-3c2a7d774c1b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("2c04abc1-b9a4-4643-b09b-50dbff770593"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("2c6763ed-cef5-4a9c-85a4-8230cc0cbc7f"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("305c9c29-10cf-46cf-b750-07502f55e741"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("31459779-afd6-4ff9-baa2-ce5de7356ee6"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("347dacf9-99cf-4eb7-8535-9be16db91dca"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("34af86c4-f4e9-473e-8d16-34b705df1b6f"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("366212d2-50af-4f10-974a-7c63174f99c6"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("369186a3-3e99-48c4-9d9c-820205374134"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("370cba56-d9df-4603-bc97-a300d5c1bfb4"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("3ab3ba9d-6a81-49ea-8fb7-2a86a158db1e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("3c335b3b-7a3f-4a9f-849f-aa10c56625e9"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("3ce209e4-6515-4646-9634-70851a07c8bc"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("41e02f04-5e84-431b-87a3-3469a473c36d"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("44affeb1-b2c9-4e66-a75c-94b140a26c6c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("46506ecd-e1e6-4fd4-b5ce-64677e423013"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("49231416-5c4d-440e-88b5-0d77fa2bd3e9"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("492e1fd6-4b9b-4942-bda9-cc4bb4bc0457"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("4bd2985b-467e-4de9-ba4f-a6afce5cee59"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("58d4fff7-10ab-40c4-b3aa-1ce38069127e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("5d609876-79c6-4fc5-9a17-ba87915672be"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("5e25fb6d-ea54-4b83-8a58-3a5e9996989b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("6182086a-1b14-4255-b097-1bea18ce8fc0"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("61d7b778-176d-4ca7-9e65-2be2e4a25505"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("6b9ad635-d16a-41b4-af51-482b6dd8e629"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("70d7e5c6-e96f-468d-a2da-c7bf38b4a846"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("71f52d8a-8587-4478-9ce8-1a7799c28bd0"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("7501540c-d555-4d0d-8518-c953dc829246"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("75e87c60-9680-48f1-b0ba-38c23bc42cc4"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("7f5c39b6-922e-4cf4-bf14-d74453bf403e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("7f9118da-393d-400c-96a1-d86e5c95196c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("7fff3ebc-926e-47b2-bac9-fd7f8f92eef1"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("8060d2eb-e417-441e-bbeb-eceb551ddc9c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("8336bb8f-d2f6-4871-9616-9f4ec39ef4e2"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("86fc9f31-3477-4613-9e64-73ffb85c8428"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("89a2156e-d446-4108-b26f-97eda6eb00dd"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("8b71c2c2-3e64-4973-a7ac-b7bee2563862"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("9013e776-dc48-47b6-9e14-2a790806605c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("90dda066-9bc7-4e5c-bb53-a5ed23c90a30"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("94efbe12-510d-4197-829e-73d501bddc3b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("951f9d3d-f47b-43d9-aa38-b5fe43984175"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("9769aedf-c0db-4559-833a-be078a5c8f7b"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("97f84802-cbe5-447b-8615-61504b6c1bf5"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("9853af84-c3fc-4347-ac6a-8f6acc914a11"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("9c102965-685c-42ff-803f-7564c889d1fe"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("9d70d2ac-30ed-472c-a380-b35a582fed69"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("a1e621fe-d458-469f-9735-eb43a3f08122"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("a337263e-1a73-4d89-94d9-1cb9d8fca4e3"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("a99e12f5-90a0-429d-8933-6dae30e6550a"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("ab025ed4-8dcb-4dc9-950f-5c7f4a82cd00"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("ab6d3972-550e-40f5-b33d-f0a6b694fc76"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("acaf5846-4523-4d0d-afce-ed7cf3dd1847"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("b32613fe-a528-4ee9-a156-5825a8514d79"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("b4c9444d-de46-4c9f-9029-2c1c7fe4885c"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("c0c11de4-7fbe-493a-a2e5-8d72b0a912ce"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("c54ae230-6f1a-44cf-b3ea-7b1611a0962f"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("c599221b-2267-404e-840e-513bbee28062"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("c74d2a4f-c6c1-4531-9b22-7b0e6c300137"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("cb26cdbb-2010-489b-ac98-52854ba8f7f4"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("cb97679d-e3b5-4949-98bb-48b62d60da1e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("cbeeaf8c-e41b-44fb-92bd-cf2dc8d39c1d"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("cc259c28-03ba-4645-9821-10ec08d97a6e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("dc915010-0eab-4bd9-a290-23a40ebd739e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e05aa6a0-e952-4b8f-8fbf-a64f2f461382"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e0c7f1c2-7fed-40ff-a7e2-6eecafb16602"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e22643bf-1a13-4130-8f02-560a0d4f84f7"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e5386b3d-cbea-499c-8557-56861a96e428"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e7a29819-f199-4546-98d3-9379b1a3391e"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("e7c89034-8ecf-4162-b8f8-95a2cef0901d"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("ebae5e19-b4bf-43ab-be91-68ae3a09958a"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("f004a1ca-a1a7-4fb9-a001-8541a408afe7"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("f18cae55-3f16-48ac-8852-74652e5a500a"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("faa2918b-ef88-4acd-9a3d-2e1350f6e284"));

            migrationBuilder.DeleteData(
                table: "Promessas",
                keyColumn: "Id",
                keyValue: new Guid("faeee589-c351-4c12-a786-28c34d3c1d60"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: new Guid("32ec5321-5b2b-4dfe-992b-b9748d035e82"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("15699966-86d5-4d82-9ead-3b1b649145bc"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("181aa82a-2bc3-489d-b0e1-cb052e540552"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("1e2e0c25-7e51-479a-b672-0bb7f0b24605"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("23e1cfe8-3b5d-48fd-83c0-d15aa8621a70"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("35252558-5c54-40c2-8054-9b7e5e19acd7"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("35d94842-8122-471d-99d5-96d297db4e4b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("3908a6b3-51e9-48e8-b433-caea24dd12a6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("3915ca1b-78d2-49fe-85d7-8223c73e744c"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("4890165d-36ed-4165-b2db-80847e6f8af1"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("5540a4e3-064e-4d83-84d8-6d23f129e637"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("5b4c7b49-e707-4050-810c-a72bfcb53949"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("8d7f5027-6aa1-4192-9c8c-2aa2ecd1dab6"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("91aa8f43-adb8-4327-965d-29d52a6f5720"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("a16e9e8f-4c53-4cf9-9976-a3f8140e863b"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("acac26a9-0ed8-41a3-b1be-a757115d9e7e"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("beb9ce2a-2c86-4046-b4e5-6e407a042270"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("c524c2e9-ed7f-4fca-a1e5-c866ee967c0a"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("ceeb2582-610c-44d1-8618-3e10043a7f27"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("e146f7b3-9fb6-4cbf-9173-4911a7daa122"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("f15fc27b-dc67-417d-afdb-db2922c336a2"));

            migrationBuilder.DeleteData(
                table: "Vereadores",
                keyColumn: "Id",
                keyValue: new Guid("fc132ac6-609f-48f6-b302-8d910e0fbb9f"));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AceitouOsTermos", "Email", "Nome", "SenhaCriptografada", "Telefone" },
                values: new object[] { new Guid("8e54ceb0-04ef-41ac-8cc1-e857827ba790"), true, "adm@gmail.com", "ADMINISTRADOR", "1h0ATANFe6x7kMHo1PURE74WI0ayevUwfK/+Ie+IWX/xWrFWngcVUwL/ewryn38EMVMQBFaNo4SaVwgXaBWnDw==", "" });

            migrationBuilder.InsertData(
                table: "Vereadores",
                columns: new[] { "Id", "CaminhoImagem", "Nome", "Partido" },
                values: new object[,]
                {
                    { new Guid("0d5c5cea-aea7-44ab-93e7-3b93b284839a"), "zeluis.jpg", "Zé Luís", "PSD" },
                    { new Guid("1e918a99-36d5-4d37-b862-eddb4909575b"), "julianafraga.jpg", "Juliana Fraga", "PT" },
                    { new Guid("2792b548-f56a-4df8-a10d-c74136104b29"), "senna.jpg", "Senna", "PL" },
                    { new Guid("2a763dee-a189-410f-91d3-08274608cc2c"), "fernandopetiti.jpg", "Fernando Petiti", "PSDB" },
                    { new Guid("46b7b815-4dc4-4b04-9943-4e15cb69a3a3"), "claudioapolinario.jpg", "Cláudio Apolinário", "PSD" },
                    { new Guid("47f336a2-05d6-43e0-9d54-9ca34d79fcdf"), "thomazhenrique.jpg", "Thomaz Henrique", "PL" },
                    { new Guid("4a09d1c3-90e4-4afa-a8b8-18f4a451cec6"), "rafaelpascucci.jpg", "Rafael Pascucci", "PSD" },
                    { new Guid("4ecc62a7-98fe-40d8-a064-bd40a3eebac1"), "miltonvieirafilho.jpg", "Milton Vieira Filho", "REPUBLICANOS" },
                    { new Guid("613f5f6d-8e5c-43c7-be78-6c5981f65ad1"), "sergiocamargo.jpg", "Sérgio Camargo", "PL" },
                    { new Guid("8cf43309-6ea6-45fb-8cfd-fa12412ed917"), "robertodoeleven.jpg", "Roberto do Eleven", "PSD" },
                    { new Guid("91243476-d9c0-40bd-a071-aae33fb24f9d"), "rogeriodaacasem.jpg", "Rogério da Acasem", "PP" },
                    { new Guid("91831de7-6806-4939-9385-5861808b9349"), "marcelogarcia.jpg", "Marcelo Garcia", "PRD" },
                    { new Guid("a2ebdaee-25ef-448e-8829-76b9ef6c20f2"), "marcaodaacademia.jpg", "Marcão da Academia", "PSD" },
                    { new Guid("a2f79f19-a026-46fd-9e6c-70fc8e696979"), "sidneycampos.jpg", "Sidney Campos", "PSDB" },
                    { new Guid("b38e8455-1d46-490d-9045-60e47b2ed1cb"), "renatosantiago.jpg", "Renato Santiago", "UNIÃO" },
                    { new Guid("c19328e6-5083-40aa-addd-0e5403d1ba15"), "robertochagas.jpg", "Roberto Chagas", "PL" },
                    { new Guid("c7371ee0-c96a-454b-9770-2488b177c782"), "carlosabranches.jpg", "Carlos Abranches", "CIDADANIA" },
                    { new Guid("c82016c8-1527-4516-a1af-e8007e55fe36"), "amelianaomi.jpg", "Amélia Naomi", "PT" },
                    { new Guid("e41797cc-97bb-467f-b864-632bd495c43f"), "linobispo.jpg", "Lino Bispo", "PL" },
                    { new Guid("f43b2d58-49f1-4dbd-b869-57296870a266"), "fabiaozagueiro.jpg", "Fabião Zagueiro", "PSD" },
                    { new Guid("fb1109d2-a13b-423e-bf97-a58ad8bd5c88"), "gilsoncampos.jpg", "Gilson Campos", "PRD" }
                });
        }
    }
}
