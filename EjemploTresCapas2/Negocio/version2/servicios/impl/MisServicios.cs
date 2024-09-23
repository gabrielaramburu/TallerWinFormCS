using Negocio.version2.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version2.servicios.impl
{
    public class MisServicios: IServiciosNegocio
    {
        //observar como en esta versión la lista de vehiculos pasa a ser un miembro
        //de clase 
        private static IList<Vehiculo> _vehiculos = new List<Vehiculo>();

        public MisServicios() {
            //solo inicializo cuando la lista está vacia
            //esto es porque todabía no tenemos capa de presentación
            if (_vehiculos.Count == 0)
            {
                _vehiculos.Add(new Vehiculo(1, "sbu 111", "ford", "kia"));
                _vehiculos.Add(new Vehiculo(2, "sbu 222", "ford", "fiesta"));
                _vehiculos.Add(new Vehiculo(3, "sbu 222", "toyota", "corolla"));
            }
        }

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            //calculo el ID del nuevo vehiculo
            vehiculo.Id = _vehiculos.Count() + 1;

            _vehiculos.Add(vehiculo);
        }

        public IList<Vehiculo> obtenerVehiculos()
        {
            return _vehiculos;
        }
    }
}
