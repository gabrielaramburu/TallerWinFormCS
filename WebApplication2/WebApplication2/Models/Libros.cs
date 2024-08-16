namespace WebApplication2.Models
{
    public class Libro
    {
        public string ISBN { get; set; }
        public string Titulo { get; set; }

        public Libro(string isbn, string titulo)
        {
            ISBN = isbn;
            Titulo = titulo;
        }
    }
}
