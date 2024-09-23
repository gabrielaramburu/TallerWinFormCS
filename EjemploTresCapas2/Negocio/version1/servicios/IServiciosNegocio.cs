using Negocio.version1.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version1.servicios
{
    public interface IServiciosNegocio
    {
        public IList<Vehiculo> obtenerVehiculos();
    }
}
