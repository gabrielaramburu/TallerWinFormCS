using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Negocio.version4.dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version4.persistencia
{
    internal class VehiculoContext : DbContext
    {
        public string DbPath { get; }

        public VehiculoContext() {

            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "tallerNet.db");
            //crea la base de datos en 
            //C:\Users\[usuario]\AppData\Local\tallerNet.db
            //pero se puede crear en cualquier lugar
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Marca> Marcas { get; set; }


        //establezco el nombre de la base de datos
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            Console.WriteLine($"creando data base: {DbPath}");
                //$ interpolación de strings
                optionsBuilder.UseSqlite($"Data Source={DbPath}");

        }
                

        //por defecto le cargo valores
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Marca ford = new Marca(1, "Ford");
            Marca nissan = new Marca(2, "Nissan");
            Marca peu = new Marca(3, "Peugeot");

            modelBuilder.Entity<Marca>().HasData(
                ford,
                nissan,
                peu);

            /*
            modelBuilder.Entity<Vehiculo>().Property(e => e.Id).ValueGeneratedOnAdd()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Save);

            modelBuilder.Entity<Vehiculo>().Property(e => e.Id).Metadata.SetField("_id");
           
            modelBuilder.Entity<Vehiculo>()
                .HasData(new { Modelo = "Sentra", Matricula = "sbu 1111"}); 
                
            */
           
        }
    }
}