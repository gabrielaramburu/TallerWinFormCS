using Negocio.version1.servicios;
using Negocio.version1.servicios.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploTresCapas2.version1
{
    public partial class FormVersion1 : Form
    {
        public FormVersion1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //IServicio es el contrato (interface)
            //MisServicios es la implementación (comportamiento)
            IServiciosNegocio servicios = new MisServicios();

            this.dgVehiculos.DataSource = servicios.obtenerVehiculos();
            this.dgVehiculos.Refresh();
        }
    }
}
