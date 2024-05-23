namespace Examen
{
    public class Libros_Elec : Libro
    {
        public string Formato { get; set; }
        public string Tamano { get; set; }

        public Libros_Elec()
        { 
            Formato = string.Empty;
            Tamano = string.Empty;
        }
    }
}
