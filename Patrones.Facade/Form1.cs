using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patrones.Facade
{
    public partial class Form1 : Form
    {
        private readonly FachadaUniversidad _facade;
        private readonly Alumno _alumnoDemo;
        private readonly Empleado _empleadoDemo;

        public Form1()
        {
            InitializeComponent();

            _facade = new FachadaUniversidad(new Administracion(),new Bedelia(),new RecursosHumanos());

            _alumnoDemo = new Alumno(id: 1, nombre: "Ana Pérez", legajo: "A-2024-001");
            _empleadoDemo = new Empleado(id: 10, nombre: "Luis Gómez", cuil: "20-12345678-9", puesto: "Bedel");
        }

        private void Log(string texto) => lstLog.Items.Add(texto);

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            var r = _facade.InscribirAlumno(_alumnoDemo, "Ingeniería en Sistemas");
            Log(r.Mensaje);
            if (!r.Ok) MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnExamen_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            var r = _facade.AnotarAExamen(_alumnoDemo, "Algoritmos I");
            Log(r.Mensaje);
            if (!r.Ok) MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnCuota_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            var r = _facade.CobrarCuota(_alumnoDemo, 35000m);
            Log(r.Mensaje);
            if (!r.Ok) MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
            var r = _facade.PagarSueldo(_empleadoDemo, 650000m);
            Log(r.Mensaje);
            if (!r.Ok) MessageBox.Show(r.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
