using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version3.dominio
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public string Matricula { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }


        public Vehiculo(int id, string matricula, Marca marca, string modelo)
        {
            Id = id;
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo(string matricula, Marca marca, string modelo)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public void TocarBocina()
        {

        }
    }
}
