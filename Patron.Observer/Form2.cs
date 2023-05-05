using Patron.Observer.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Patron.Observer
{
    public partial class Form2 : Form, IObservador
    {
        private Sesion sesion = Sesion.GetInstance();
        public Form2()
        {
            InitializeComponent();
        }

        public void Actualizar(IIdioma idiomaObservado)
        {
            foreach (Control item in this.Controls)
            {
                item.Text = idiomaObservado.BuscarTraduccion(item.Tag.ToString());
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            sesion.RegistrarObservador(this);
            Actualizar(sesion.idioma);
        }
    }
}
