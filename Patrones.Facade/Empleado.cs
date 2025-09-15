namespace Patrones.Facade
{
    public class Empleado : Persona
    {
        public string Cuil { get; }
        public string Puesto { get; }

        public Empleado(int id, string nombre, string cuil, string puesto)
            : base(id, nombre)
        {
            Cuil = cuil;
            Puesto = puesto;
        }
    }
}