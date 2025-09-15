namespace Patrones.Facade
{
    public abstract class Persona
    {
        public int Id { get; }
        public string Nombre { get; }

        protected Persona(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        public override string ToString() => $"{Id} - {Nombre}";
    }
}