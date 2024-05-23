namespace Examen
{
    public class Revistas : Libro
    {
        public string Volumen {  get; set; }
        public string Numero {  get; set; }

        public Revistas ()
        {
            Volumen = string.Empty;
            Numero = string.Empty;

        }


    }
}
