using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoExamen1
{
    public partial class FrmResumen : Form
    {
        public FrmResumen(string nombre, string dni, string telefono, string vehiculo)
        {
            InitializeComponent();
            lblNombre.Text = nombre;
            lblDni.Text = dni;
            lblTelefono.Text =  telefono;
            lblVehiculo.Text = vehiculo;
        }

        private void FrmResumen_Load(object sender, EventArgs e)
        {

        }
    }
}
