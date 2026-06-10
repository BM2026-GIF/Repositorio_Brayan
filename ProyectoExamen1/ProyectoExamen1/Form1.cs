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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmSolicitud_Load(object sender, EventArgs e)
        {
            
            cmbVehiculo.Items.Add("Turismo");
            cmbVehiculo.Items.Add("SUV");
            cmbVehiculo.Items.Add("Pickup");
        }
       

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
            cmbVehiculo.SelectedIndex = -1;
            picVehiculo.Image = null;
        }

        private void btnVerResumen_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del cliente.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtDni.Text))
            {
                MessageBox.Show("Debe ingresar el DNI.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe ingresar el teléfono.");
                return;
            }
            if (cmbVehiculo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un vehículo.");
                return;
            }

            
        }
    }
}

