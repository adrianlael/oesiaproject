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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            this.InitializeComponent();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Añadir()
        {

        }

        public virtual void Modificar()
        {

        }

        public virtual Boolean Guardar()
        {
            return false;
        }
    }
}
