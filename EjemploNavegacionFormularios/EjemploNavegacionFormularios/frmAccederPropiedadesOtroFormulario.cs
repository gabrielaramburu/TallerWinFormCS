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
    public partial class frmAccederPropiedadesOtroFormulario : Form
    {
        private frmPrincipal? principal;

        public frmAccederPropiedadesOtroFormulario()
        {
            InitializeComponent();
        }

        //observar que implemento otro constructor
        public frmAccederPropiedadesOtroFormulario(frmPrincipal principal)
        {
            InitializeComponent();
            this.principal = principal;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            String valor = this.principal.cboSeleccion.Text;
            MessageBox.Show(valor);
        }

        private void frmAccederPropiedadesOtroFormulario_Load(object sender, EventArgs e)
        {

        }
    }
}
