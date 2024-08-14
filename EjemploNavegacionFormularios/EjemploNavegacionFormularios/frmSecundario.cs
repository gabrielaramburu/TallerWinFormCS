using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploNavegacionFormularios
{
    public partial class frmSecundario : Form
    {
        public frmSecundario()
        {
            InitializeComponent();
        }

        private void frmSecundario_Load(object sender, EventArgs e)
        {

        }

        public void cambiarEtiquetaDescripcion(String desc) { 
            this.lblDescripcion.Text = desc;
        }

        public void cambiarEtiquetaTipoForm(String desc)
        {
            this.lblTipoFormulario.Text = desc;
        }
    }
}
