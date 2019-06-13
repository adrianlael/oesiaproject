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
            try
            {
                SqlConnection conectar = new SqlConnection(@"Data Source=GO070135\SQLEXPRESS;Initial Catalog=tienda;Integrated Security=True");

                conectar.Open();
                MessageBox.Show("Conexión establecida");
            }
            catch(Exception error)
            {
                MessageBox.Show("No se ha podido conectar" + error.Message);
            }
            //if (this.usuario.Text == "administrador" && this.contraseña.Text == "admin123")
            //{
            //    this.Hide();
            //    Menu menu = new Menu();
            //    menu.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Usuario o contraseña incorrecto");
            //    this.usuario.Text = "";
            //    this.contraseña.Text = "";
            //    this.usuario.Focus();
            //}
        }
        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }       
    }
}
