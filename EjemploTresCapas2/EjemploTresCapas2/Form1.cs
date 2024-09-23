using EjemploTresCapas2.version1;
using EjemploTresCapas2.version2;
using EjemploTresCapas2.version3;

namespace EjemploTresCapas2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVersion1_Click(object sender, EventArgs e)
        {
            FormVersion1 frmV2 = new FormVersion1();
            frmV2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lblVersion1.Text = "Versión básica que recupera datos desde la capa de negocio" +
                " y muestra los mismos en una grilla";

            this.lblVersion2.Text = "Versión que recupera datos y agrega nueva información";
            this.lblVersion3.Text = "Versión que permite actualizar datos y agrega combo box de marcas";
        }

        private void btnVersion2_Click(object sender, EventArgs e)
        {
            FormVersion2 formV2 = new FormVersion2();
            formV2.ShowDialog();
        }

        private void btnVersion3_Click(object sender, EventArgs e)
        {
            FormVersion3 fromV3 = new FormVersion3();
            fromV3.ShowDialog();
        }
    }
}
