using Microsoft.EntityFrameworkCore;
using Negocio.version4.dominio;
using Negocio.version4.persistencia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version4.servicios.impl
{
    public class MisServicios: IServiciosNegocio
    {

        private static VehiculoContext? dbContext;

        public MisServicios() {
            if (dbContext == null)
            {
                dbContext = new VehiculoContext();

                //observar que cada vez que inicializo la aplicación 
                //se borra y se crea la base de datos
                dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
         
        }

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            dbContext.Add(vehiculo);
            dbContext.SaveChanges();
        }

        public IList<Vehiculo> ObtenerVehiculos()
        {
            return dbContext.Vehiculos.ToList<Vehiculo>();
            
        }

        public IList<Marca> ObtenerMarcas() {
            return dbContext.Marcas.ToList<Marca>();

        }

        public bool ModificarVehiculo(Vehiculo vehiculoModificado)
        {

            var vehiculo = dbContext.Vehiculos.Single(v => v.Id == vehiculoModificado.Id);
            vehiculo.Marca = vehiculoModificado.Marca;
            vehiculo.Matricula = vehiculoModificado.Matricula;
            vehiculo.Modelo = vehiculoModificado.Modelo;
            try
            {
                dbContext.SaveChanges();
                return true;
            }
            catch (DbUpdateConcurrencyException)
            {
                //aca tengo que logear la excepcion
                return false;
                
            }
        }

        public bool Borrar(int id)
        {
           
            var vehiculo = dbContext.Vehiculos.Single(v => v.Id == id);
            dbContext.Remove(vehiculo);
            dbContext.SaveChanges(true);
            return true; //hay que mejorar el manejejo de errores
        }
    }
}
