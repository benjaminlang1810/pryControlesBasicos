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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = e.X.ToString();
            lblY.Text = e.Y.ToString();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblBienvenido_Click(object sender, EventArgs e)
        {
            
        }

        private void frmPrincipal_Click(object sender, EventArgs e)
        {
            lblBienvenido.Visible = true;
        }

        private void lblBienvenido_Move(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Move(object sender, EventArgs e)
        {
            
        }

        Random random = new Random();


        private void lblBienvenido_MouseEnter(object sender, EventArgs e)
        {
            lblBienvenido.Location = new Point(random.Next(10, 1000), random.Next(10, 500));

        }

        private void cmdFormulario2_Click(object sender, EventArgs e)
        {
            Formulario2 principal = new Formulario2(); 
            principal.ShowDialog();

            
           
        }
    }
}
