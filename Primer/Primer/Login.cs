using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;

namespace Primer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.usuario.Select();
        }

        private void Login_Load(object sender, EventArgs e)
        {
         
        }

        private void Login_Click(object sender, EventArgs e)
        {
            try
            {
                string validar = string.Format("SELECT * FROM usuario WHERE username = '{0}' AND password = '{1}'", this.usuario.Text.Trim(),this.contraseña.Text.Trim());
                DataSet conectar = Biblioteca.Herramientas(validar);

                string cuenta = conectar.Tables[0].Rows[0]["username"].ToString().Trim();
                string contrasena = conectar.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == this.usuario.Text.Trim() && contrasena == this.contraseña.Text.Trim())
                {
                    MessageBox.Show("Ha iniciado sesión correctamente");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();
                }  
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña inválidos");
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
