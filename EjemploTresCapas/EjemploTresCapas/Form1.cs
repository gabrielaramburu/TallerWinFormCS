
using Negocio.impl;
using Negocio;
namespace EjemploTresCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvocarNegocio_Click(object sender, EventArgs e)
        {
            IOperacionesNegocio oper = new MisOperaciones();
            MessageBox.Show(oper.Saludar());
        }
    }
}
