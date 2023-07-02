using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryControlesBasicos
{
    public partial class Formulario2 : Form
    {
        public Formulario2()
        {
            InitializeComponent();
        }

        private void lblTransformacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (optRojo.Checked == true)
            {
                lblTransformacion.ForeColor = Color.Red;
                txtEscribir.ForeColor = Color.Red;
            }

            if (optAzul.Checked == true)
            {
                lblTransformacion.ForeColor = Color.Blue;
                txtEscribir.ForeColor = Color.Blue;
            }
        }

        private void txtEscribir_TextChanged(object sender, EventArgs e)
        {
            lblTransformacion.Text= txtEscribir.Text;   
        }
    }
}
