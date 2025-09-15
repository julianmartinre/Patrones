namespace Patrones.Facade
{
    public class Administracion
    {
        public int CobrarCuota(Alumno alumno, decimal importe)
        {
            return (alumno.Id * 1000) + (int)importe;
        }
    }
}