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
    public partial class AñadirClientes : FormBase
    {
        public AñadirClientes()
        {
            this.InitializeComponent();
        }

        private void AñadirClientes_Load(object sender, EventArgs e)
        {

        }

        public override bool Guardar()
        {
            try
            {
                string insertar = string.Format("EXEC AñadirClientes '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}'", 
                this.textBoxNifnie.Text.Trim(),this.textBoxNombre.Text.Trim(),this.textBoxPrimerapellido.Text.Trim(), this.textBoxSegundoapellido.Text.Trim(),
                this.textBoxCalle.Text.Trim(), this.textBoxPais.Text.Trim(), this.textBoxCiudad.Text.Trim(), this.textBoxProvincia.Text.Trim(),
                this.textBoxTelefono.Text.Trim());

                Biblioteca.Herramientas(insertar);
                MessageBox.Show("El cliente ha sido creado");
                return true;
            }
            catch(Exception)
            {
                MessageBox.Show("Error, inténtelo de nuevo");
                return false;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            this.Guardar();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clientes clientes = new Clientes();
            clientes.Show();
        }
    }
}
