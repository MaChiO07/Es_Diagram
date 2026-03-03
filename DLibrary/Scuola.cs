using System.Reflection.Metadata.Ecma335;

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



        public static double[] CalcolaMediaVotiMesePerMese(Studente studente, int anno)
        {
            if (anno < 0)
                throw new ArgumentException("L'anno deve essere positivo.");

            double[] medie = new double[12];

            // Per ogni mese (1–12)
            for (int mese = 1; mese <= 12; mese++)
            {
                // Lista temporanea dei voti del mese
                List<Voto> votiDelMese = new List<Voto>();

                // Scorriamo tutti i voti dello studente
                foreach (var voto in studente.Voti)
                {
                    if (voto.Data.Year == anno && voto.Data.Month == mese)
                    {
                        votiDelMese.Add(voto);
                    }
                }

                // Se non ci sono voti media = 0
                if (votiDelMese.Count == 0)
                {
                    medie[mese - 1] = 0;
                }
                else
                {
                    Studente s = new Studente { Voti = votiDelMese };
                    medie[mese - 1] = CalcolaMediaVoti(s);
                }
            }

            return medie;
        }


        public static void StampaMedieMensili(Studente studente, int anno)
        {
            double[] medie = CalcolaMediaVotiMesePerMese(studente, anno);

            Console.WriteLine($"Medie dei voti per l'anno {anno}:");

            string[] nomiMesi = new string[]
            {
                "Gennaio", "Febbraio", "Marzo", "Aprile",
                "Maggio", "Giugno", "Luglio", "Agosto",
                "Settembre", "Ottobre", "Novembre", "Dicembre"
            };

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine($"{nomiMesi[i]}: {medie[i]:0.00}");
            }
        }




    }



}
