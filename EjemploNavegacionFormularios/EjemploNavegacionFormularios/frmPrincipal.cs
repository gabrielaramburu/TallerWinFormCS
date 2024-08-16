namespace EjemploNavegacionFormularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAbrirModal_Click_1(object sender, System.EventArgs e)
        {
            frmSecundario form1 = new frmSecundario();
            form1.cambiarEtiquetaTipoForm("Abrí el formulario de tipo modal");
            form1.cambiarEtiquetaDescripcion("Observar que no puedo hacer otra cosa fuera del formulario");
            form1.ShowDialog();
        }

        private void btnNoModal_Click_1(object sender, System.EventArgs e)
        {
            frmSecundario form1 = new frmSecundario();
            form1.cambiarEtiquetaTipoForm("Abrí el formulario de tipo NO modal");
            form1.cambiarEtiquetaDescripcion("Observar que puedo abrir varias instancias de dicho formulario");

            form1.Show();
        }

        private void btnAvanzar_Click(object sender, EventArgs e)
        {
            //observar como paso este formulario (this) al 
            //formulario que estoy llamando
            frmAccederPropiedadesOtroFormulario frmAvanzar
                = new frmAccederPropiedadesOtroFormulario(this);
            frmAvanzar.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void CambiarTituloEtiquetaDePrueba(String texto)
        {
            this.etiqueta.Text = texto;

        }
    }
}
