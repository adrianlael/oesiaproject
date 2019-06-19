using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;

namespace Primer
{
    public partial class DatosClientes : FormBase
    {
        public DatosClientes()
        {
            this.InitializeComponent();
        }

        private void DatosCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }

        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarClientes '{0}'", this.textBoxNifnie.Text.Trim());
      
                DialogResult resultado = MessageBox.Show("¿Está seguro?", "", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    Biblioteca.Herramientas(eliminar);
                    MessageBox.Show("Se ha eliminado correctamente");
                }
                else if (resultado == DialogResult.No)
                {
                    this.Hide();
                    Clientes clientes = new Clientes();
                    clientes.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Eliminar();
        }
    }
}
