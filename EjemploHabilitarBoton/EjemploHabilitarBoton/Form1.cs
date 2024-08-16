namespace EjemploHabilitarBoton
{
    public partial class Form1 : Form
    {
        private int totalIngresos = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
            habilitarControlAvanzar();
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {
            habilitarControlAvanzar();
        }

        private void txtValor3_TextChanged(object sender, EventArgs e)
        {
            habilitarControlAvanzar();
        }

        private void habilitarControlAvanzar()
        {
            if (txtValor1.Text.Length > 0 && txtValor2.Text.Length > 0
                && txtValor3.Text.Length > 0)
            {
                this.btnContinuar.Enabled = true;
            }
            else { this.btnContinuar.Enabled = false; }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
