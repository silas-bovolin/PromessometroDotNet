using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Promessometro.Dominio.Abstractions;

public class Result
{
    protected internal Result(bool isSuccess, Error error)
    {
        if (isSuccess && error != Error.None)
        {
            throw new InvalidOperationException("Resultado não foi informado corretamente: Não é possível criar um resultado com valor true e um Error diferente de nulo");
        }

        if (!isSuccess && error == Error.None)
        {
            throw new InvalidOperationException("Resultado não foi informado corretamente: Não pode criar um resultado com valor false e um Error nulo");
        }

        IsSuccess = isSuccess;
        Error = error;
    }

    public bool IsSuccess { get; }
    public bool IsFailure => !IsSuccess;
    public Error Error { get; }
    public static Result<TValue> Create<TValue>(TValue? value) =>
        value is not null ? Success(value) : Failure<TValue>(Error.NullValue);
    public static Result<TValue> Success<TValue>(TValue value) => new(value, true, Error.None);
    public static Result<TValue> Failure<TValue>(Error error) =>
        new(default, false, error);
}

public class Result<TValue> : Result
{
    private readonly TValue? _value;
    
    protected internal Result(TValue? value, bool isSuccess, Error error)
        : base(isSuccess, error)
    {
        _value = value;
    }

    [NotNull]
    public TValue Value => IsSuccess
        ? _value!
        : throw new InvalidOperationException("O valor de uma resultado de falha não pode ser acessado.");

    public static implicit operator Result<TValue>(TValue? value) => Create(value);

}