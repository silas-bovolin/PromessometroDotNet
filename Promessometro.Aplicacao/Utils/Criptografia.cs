using Effortless.Net.Encryption;

namespace Promessometro.Aplicacao.Utils;

public static class Criptografia
{
    public static string Criptografar(string data)
        => Hash.Create(HashType.SHA512, data, string.Empty, false);
}