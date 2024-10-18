using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version4.dominio
{
    public class Vehiculo
    {
       
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Matricula { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
      
        public Vehiculo(string matricula, Marca marca, string modelo)
        {
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }

        public Vehiculo(int id , string matricula, Marca marca, string modelo)
        {   Id = id; 
            Matricula = matricula;
            Marca = marca;
            Modelo = modelo;
        }
        public Vehiculo() { }


        public void TocarBocina()
        {

        }
    }
}
