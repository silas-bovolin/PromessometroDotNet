namespace Promessometro.Infraestrutura.Authentication;

public class JwtOptions
{
    public string Issuer { get; } = "PromessometroIssuer";
    public string Audiencie { get; } = "PromessometroAudiencie";
    public string SecretKey { get; } = "Mi!dsFoÇfmso2#n$uIn36d92çRm_p3c%3";
}