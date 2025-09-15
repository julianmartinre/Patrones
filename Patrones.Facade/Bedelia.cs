using Patrones.Facade;

public class Bedelia
{
    public int InscribirAlumno(Alumno alumno, string carrera)
    {
        return (alumno.Id * 10) + carrera.Length;
    }

    public int AnotarAExamen(Alumno alumno, string materia)
    {
        return (alumno.Id * 100) + materia.Length;
    }
}