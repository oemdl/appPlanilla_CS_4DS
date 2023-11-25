using System;
using System.Drawing;
using System.Windows.Forms;

namespace appPlanilla_CS_4DS.ui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Enter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Black;
        }

        private void btn_Leave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(94,17,90);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.Aquamarine;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            ((TextBox)sender).BackColor = Color.White;
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void pibSalir_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("¿Desea salir?", "Salir", 
                 MessageBoxButtons.YesNo, 
                 MessageBoxIcon.Question ) == DialogResult.Yes )
                Application.Exit();
        }
    }
}
