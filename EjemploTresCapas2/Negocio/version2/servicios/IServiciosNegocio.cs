using Negocio.version2.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version2.servicios
{
    public interface IServiciosNegocio
    {
        public IList<Vehiculo> obtenerVehiculos();

        public void agregarVehiculo(Vehiculo vehiculo);
    }
}
