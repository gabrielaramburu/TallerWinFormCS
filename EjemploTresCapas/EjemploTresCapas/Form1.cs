
using Negocio.dominio;
using Negocio.servicios;
using Negocio.servicios.impl;
using System.ComponentModel;

namespace EjemploTresCapas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCargarVehiculos_Click(object sender, EventArgs e)
        {

            IServiciosNegocio servicios = new MisServicios();

            // La columan Matricula tiene que existir en el control
            //Tambien la podría crear por código
            this.dgVehiculos.Columns["Matricula"].DataPropertyName = "Matricula";
            this.dgVehiculos.Columns["Marca"].DataPropertyName = "Marca";
            this.dgVehiculos.Columns["Modelo"].DataPropertyName = "Modelo";

            this.dgVehiculos.DataSource = servicios.obtenerVehiculos();
            this.dgVehiculos.Refresh();
            
            

        }
    }
}
