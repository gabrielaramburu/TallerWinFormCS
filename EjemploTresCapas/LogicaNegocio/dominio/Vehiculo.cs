using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.dominio
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }


        public Vehiculo (int id,  string matricula, string marca, string modelo)
        {
            Id = id;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }
    }
}
