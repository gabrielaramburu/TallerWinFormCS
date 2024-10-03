using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio.version3.dominio
{
    public class Marca
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Marca(int id, string nombre) {
            this.Nombre = nombre;
            this.Id = id;
        }

        public virtual bool Equals(Marca obj)
        {
            //siempre que busco un objeto en una colección tengo que sobreescribir 
            //el método equals
            if (obj == null)
            {
                return false;
            }
            return (this.Id == obj.Id);
        }

        public override String ToString()
        {
            //notar que tengo que sobreescribir el método ToString para que se muestre
            //correctamente en la capa de presentación
            return this.Nombre;
        }
    }
}
