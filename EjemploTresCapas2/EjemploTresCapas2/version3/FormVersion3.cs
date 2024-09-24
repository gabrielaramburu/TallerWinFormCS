using Negocio.version3.dominio;
using Negocio.version3.servicios;
using Negocio.version3.servicios.impl;
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
            cargarComboMarcas();
            desHabilitoCampoID();

            //no permito que el usuario modifique a mano los datos.
            this.dgVehiculos.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void cargarComboMarcas()
        {
            this.cboMarcas.Items.Clear();
            this.cboMarcas.DataSource = servicios.obtenerMarcas();
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
            Marca marca = this.cboMarcas.SelectedItem as Marca;

            //la responsabilidad de asignar el ID la tiene la capa de negocio
            Vehiculo nuevoVehiculo = new Vehiculo(
                this.txtMatricula.Text,
                marca,
                this.txtModelo.Text);

            this.servicios.agregarVehiculo(nuevoVehiculo);

            IList<Vehiculo> vehiculos = servicios.obtenerVehiculos();
            cargarGrilla(vehiculos);
            //es lo mismo hacer cargarGrilla(servicios.obtenerVehiculos());
        }

        private void dgVehiculos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell celdaId = this.dgVehiculos.Rows[e.RowIndex].Cells[0];
            DataGridViewCell celdaMatricula = this.dgVehiculos.Rows[e.RowIndex].Cells[1];
            DataGridViewCell celdaMarca= this.dgVehiculos.Rows[e.RowIndex].Cells[2];
            DataGridViewCell celdaModelo = this.dgVehiculos.Rows[e.RowIndex].Cells[3];

            this.txtId.Text = celdaId.Value.ToString();
            this.txtMatricula.Text = celdaMatricula.Value.ToString();
            this.txtModelo.Text = celdaModelo.Value.ToString();
            this.cboMarcas.SelectedItem = celdaMarca.Value;

            //notas los siguientes problemas:
            //1) si se hace click en el cabezal se produce un error
            //2) si se cambia el orden de los atributos en el objeto, este código deja de funcionar
            //ya que estamos asumiendo que por ejemplo el ID está en la celda 0
            //Todo esto se puede corregir.


        }
    }
}
