namespace Patrones.ChainOfResponsability
{
    internal class GerenteZonal : AprobadorCompra
    {
        protected override string Cargo => "Gerente zonal";

        protected override bool PuedeAprobar(decimal importe) => importe < 100m;
    }
}
