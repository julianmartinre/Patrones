namespace Patrones.ChainOfResponsability
{
    internal class Director : AprobadorCompra
    {
        protected override string Cargo => "Director";

        protected override bool PuedeAprobar(decimal importe) => importe > 1000m;
    }
}
