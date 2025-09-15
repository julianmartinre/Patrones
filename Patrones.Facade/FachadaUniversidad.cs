using Patrones.Facade;

public class FachadaUniversidad
{
    private readonly Administracion _adm;
    private readonly Bedelia _bedelia;
    private readonly RecursosHumanos _rrhh;

    public FachadaUniversidad(Administracion adm, Bedelia bedelia, RecursosHumanos rrhh)
    {
        _adm = adm;
        _bedelia = bedelia;
        _rrhh = rrhh;
    }

    public ResultadoOperacion InscribirAlumno(Alumno alumno, string carrera)
    {
        if (alumno == null || string.IsNullOrWhiteSpace(carrera))
            return Error("Datos inválidos para inscripción.");

        var nro = _bedelia.InscribirAlumno(alumno, carrera);
        return Ok(nro, $"Alumno {alumno.Nombre} inscripto a la carrera {carrera} (Nº {nro}).");
    }

    public ResultadoOperacion AnotarAExamen(Alumno alumno, string materia)
    {
        if (alumno == null || string.IsNullOrWhiteSpace(materia))
            return Error("Datos inválidos para examen.");

        var cod = _bedelia.AnotarAExamen(alumno, materia);
        return Ok(cod, $"Alumno {alumno.Nombre} anotado a {materia} (Código {cod}).");
    }

    public ResultadoOperacion CobrarCuota(Alumno alumno, decimal importe)
    {
        if (alumno == null || importe <= 0)
            return Error("Datos inválidos para cobro de cuota.");

        var recibo = _adm.CobrarCuota(alumno, importe);
        return Ok(recibo, $"Cuota cobrada a {alumno.Nombre} por {importe:C}. Recibo {recibo}.");
    }

    public ResultadoOperacion PagarSueldo(Empleado emp, decimal importe)
    {
        if (emp == null || importe <= 0)
            return Error("Datos inválidos para pago de sueldo.");

        var op = _rrhh.PagarSueldo(emp, importe);
        return Ok(op, $"Sueldo pagado a {emp.Nombre} ({emp.Puesto}) por {importe:C}. OP {op}.");
    }

    private static ResultadoOperacion Ok(int codigo, string msg) =>
        new ResultadoOperacion { Ok = true, Codigo = codigo, Mensaje = msg };

    private static ResultadoOperacion Error(string msg) =>
        new ResultadoOperacion { Ok = false, Codigo = 0, Mensaje = msg };
}