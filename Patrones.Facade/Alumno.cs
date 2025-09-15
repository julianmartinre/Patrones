namespace Patrones.Facade
{
    public class Alumno : Persona
    {
        public string Legajo { get; }

        public Alumno(int id, string nombre, string legajo)
            : base(id, nombre)
        {
            Legajo = legajo;
        }
    }
}