using Negocio.version2.dominio;
using Negocio.version2.servicios;
using Negocio.version2.servicios.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTresCapas2.version3
{
    public partial class FormVersion3 : Form
    {
        //En esta versión el contrato con la capa de negocio
        //es un atributo de instancia (para dejarlo disponible en toda la clase)
        private IServiciosNegocio servicios;
        public FormVersion3()
        {
            InitializeComponent();

            //IServicio es el contrato (interface)
            //MisServicios es la implementación (comportamiento)
            servicios = new MisServicios();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {

        }

        private void FormVersion3_Load(object sender, EventArgs e)
        {
            cargarGrilla(servicios.obtenerVehiculos());
            desHabilitoCampoID();
        }

        private void cargarGrilla(IList<Vehiculo> vehiculos)
        {
            this.dgVehiculos.DataSource = null; //para que se refresque la grilla
            this.dgVehiculos.DataSource = vehiculos;
        }

        private void desHabilitoCampoID()
        {
            this.txtId.Enabled = false;
            this.txtId.BackColor = SystemColors.ControlLight;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //la responsabilidad de asignar el ID la tiene la capa de negocio
            Vehiculo nuevoVehiculo = new Vehiculo(
                this.txtMatricula.Text,
                this.txtMarca.Text,
                this.txtModelo.Text);

            this.servicios.agregarVehiculo(nuevoVehiculo);

            IList<Vehiculo> vehiculos = servicios.obtenerVehiculos();
            cargarGrilla(vehiculos);
            //es lo mismo hacer cargarGrilla(servicios.obtenerVehiculos());






        }
    }
}
