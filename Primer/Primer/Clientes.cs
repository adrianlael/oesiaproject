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
    public partial class Clientes : Form
    {
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void buscarnifnie_Click(object sender, EventArgs e)
        {
            Biblioteca.Herramientas("SELECT * FROM Cliente WHERE id_cl = (this.nifnie_TextChanged.Text)");
        }

        private void nifnie_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
