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
    public partial class Clientes : FormBase
    {


        public Clientes()
        {
            this.InitializeComponent();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        string v_nifnie = Biblioteca.Herramientas();

        private void buscarnifnie_Click(object sender, EventArgs e)
        {
            if ( == this.nifnie.Text)
            {
                this.Hide();
                DatosClientes datosClientes = new DatosClientes();
                datosClientes.Show();
            }
            else
            {
                Biblioteca.Herramientas($"SELECT * FROM cliente WHERE id_cl = '{this.nifnie.Text}'");
                DialogResult resultado = MessageBox.Show("No existe ¿Desea crearlo?", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    this.Hide();
                    AñadirClientes añadirClientes = new AñadirClientes();
                    añadirClientes.Show();
                }
                else if (resultado == DialogResult.No)
                {
                    this.Hide();
                    Clientes clientes = new Clientes();
                    clientes.Show();
                }
            }
        }
    }
}
    
