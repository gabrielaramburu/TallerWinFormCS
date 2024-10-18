using Negocio.version4.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version4.servicios
{
    public interface IServiciosNegocio
    {
        public IList<Vehiculo> ObtenerVehiculos();
        public void AgregarVehiculo(Vehiculo vehiculo);
        public IList<Marca> ObtenerMarcas();
        public bool ModificarVehiculo(Vehiculo vehiculoModificado);
        public bool Borrar(int Id);
    }
}
