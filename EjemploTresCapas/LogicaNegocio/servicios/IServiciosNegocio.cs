using Negocio.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.servicios
{
    public interface IServiciosNegocio
    {
        public IList<Vehiculo> obtenerVehiculos();
    }
}
