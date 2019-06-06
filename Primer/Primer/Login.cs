using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(this.usuario.Text == "administrador" && this.contraseña.Text == "admin123")
            {
                MessageBox.Show("Ha ingresado correctamente");
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto");
                this.usuario.Text = "";
                this.contraseña.Text = "";
                this.usuario.Focus();
            }
        }
        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}
