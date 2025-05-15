using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Promessometro.Aplicacao.Abstractions.Contracts;
using Promessometro.Dominio.Usuarios;

namespace Promessometro.Infraestrutura.Authentication;

internal sealed class JwtProvider(IOptions<JwtOptions> options) : IJwtProvider
{
    private readonly JwtOptions options = options.Value;
    public string Generate(Usuario usuario)
    {
        var claims = new Claim[]
        {
            new(ClaimTypes.Name, usuario.Nome),
            new(ClaimTypes.Email, usuario.Email),
        };

        var signingCredentials = new SigningCredentials(
            new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(options.SecretKey)),
            SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            options.Issuer,
            options.Audiencie,
            claims,
            null,
            DateTime.Now.AddHours(1),
            signingCredentials);

        string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);

        return tokenValue;
    }
}