namespace CleanArchitecture.Domain.Vehiculos;

public record TipoMoneda
{
    public static readonly TipoMoneda None = new("");
    public static readonly TipoMoneda Usd = new("USD");
    public static readonly TipoMoneda Eur = new("EUR");
    public static readonly IReadOnlyCollection<TipoMoneda> All = new[]
    {
        Usd,
        Eur
    };
    public string Codigo { get; init; }
    private TipoMoneda(string codigo) => Codigo = codigo;
    public static TipoMoneda FromCodigo(string codigo)
    {
        return All.FirstOrDefault(c => c.Codigo == codigo) ??
                throw new ApplicationException("El tipo de moneda es inválido");
    }
}