using Negocio.version1.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version1.servicios.impl
{
    public class MisServicios: IServiciosNegocio
    {
        public IList<Vehiculo> obtenerVehiculos()
        {
            IList<Vehiculo> _vehiculos = new List<Vehiculo>();
            _vehiculos.Add(new Vehiculo(1, "sbu 111", "ford", "kia"));
            _vehiculos.Add(new Vehiculo(1, "sbu 222", "ford", "fiesta"));
            _vehiculos.Add(new Vehiculo(1, "sbu 222", "toyota", "corolla"));
            return _vehiculos;
        }
    }
}
