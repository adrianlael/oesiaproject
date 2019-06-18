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
    public partial class Articulos : FormBase
    {
        public Articulos()
        {
            this.InitializeComponent();
        }


        private void atras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

        }

        private void Articulos_Load(object sender, EventArgs e)
        {

        }

        private void color_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
