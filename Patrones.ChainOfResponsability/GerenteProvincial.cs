namespace Patrones.ChainOfResponsability
{
    internal class GerenteProvincial : AprobadorCompra
    {
        protected override string Cargo => "Gerente provincial";

        protected override bool PuedeAprobar(decimal importe) => importe <= 1000m;
    }
}
