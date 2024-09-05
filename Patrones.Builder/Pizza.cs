using Patrones.Builder.Agregados;
using Patrones.Builder.Masas;
using Patrones.Builder.Salsas;

namespace Patrones.Builder
{
    public class Pizza
    {
        Masa _masa;
        Salsa _salsa;
        Agregado _agregado;
        string _tipo;

        public override string ToString()
        {
            return $"{_tipo}, Masa: {_masa.Descripcion}, Salsa: {_salsa.Descripcion}, Agregado: {_agregado.Descripcion}";
        }

        public Pizza(Masa masa, Salsa salsa, Agregado agregado, string tipo)
        {
            _masa = masa;
            _salsa = salsa;
            _agregado = agregado;
            _tipo = tipo;
        }
    }
}