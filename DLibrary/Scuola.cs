namespace DLibrary
{
    public class Scuola
    {
        public List<Studente> Studenti { get; set; }
        public List<Insegnante> Insegnanti { get; set; }

        public Scuola()
        {
            Studenti = new List<Studente>();
            Insegnanti = new List<Insegnante>();
        }

        
        public static double CalcolaMediaVoti(Studente studente)
        {
            double result = 0;
            foreach (var voto in studente.Voti)
            {
                result += voto.Valore;
            }
            result = result / studente.Voti.Count;

            return result;
        }

        public static double CalcolaMediaVotiMesePerMese(Studente studente, int anno)
        {
            double result = 0;
            // Da completare 

            return result;
        }



    }



}
