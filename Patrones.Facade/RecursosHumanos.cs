using Patrones.Facade;

public class RecursosHumanos
{
    public int PagarSueldo(Empleado empleado, decimal importe)
    {
        return (empleado.Id * 500) + (int)importe;
    }
}