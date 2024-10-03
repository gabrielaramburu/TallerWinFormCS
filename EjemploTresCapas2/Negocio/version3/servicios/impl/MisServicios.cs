using Negocio.version3.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version3.servicios.impl
{
    public class MisServicios: IServiciosNegocio
    {
        //observar como en esta versión la lista de vehiculos pasa a ser un miembro
        //de clase 
        private static IList<Vehiculo> _vehiculos = new List<Vehiculo>();

        private static IList<Marca> _marcas = new List<Marca>();

        public MisServicios() {
            if (_marcas.Count == 0)
            {
                _marcas.Add(new Marca(1, "Ford"));
                _marcas.Add(new Marca(2, "Toyota"));
                _marcas.Add(new Marca(3, "Nissan"));
                _marcas.Add(new Marca(4, "Byd"));
            }

            //solo inicializo cuando la lista está vacia
            //esto es porque todabía no tenemos capa de presentación
            if (_vehiculos.Count == 0)
            {
                //Busco la marca en la lista de Marcas
                Marca ford = _marcas.First(m => m.Id == 1);

                _vehiculos.Add(new Vehiculo(1, "sbu 111", ford, "kia"));
                _vehiculos.Add(new Vehiculo(2, "sbu 222", ford, "fiesta"));
                _vehiculos.Add(new Vehiculo(3, "sbu 222", ford, "ranger"));
            }

            
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            //calculo el ID del nuevo vehiculo
            vehiculo.Id = _vehiculos.Count() + 1;

            _vehiculos.Add(vehiculo);
        }

        public IList<Vehiculo> ObtenerVehiculos()
        {
            return _vehiculos;
        }

        public IList<Marca> ObtenerMarcas() {
            return _marcas;
        }

        public bool ModificarVehiculo(Vehiculo vehiculoModificado)
        {
            //busco la referencia al vehiculo que quiero modificar
            //vehiculo => vehiculo.Id == vehiculoModificado.Id)
            //esta sintaxis pertenece a LINQ (Language-Integrated Query) es una funcionalidad de .NET
            //que permite realizar consulta sobre colecciones
            Vehiculo? vehiculo = _vehiculos.FirstOrDefault<Vehiculo>(vehiculo => vehiculo.Id == vehiculoModificado.Id);
            if (vehiculo != null)
            {
                //remplazo todos los datos
                vehiculo.Matricula = vehiculoModificado.Matricula;
                vehiculo.Marca = vehiculoModificado.Marca;
                vehiculo.Modelo = vehiculoModificado.Modelo;

                return true;
            }
            else return false;
            
        }
    }
}
