using System.Runtime.InteropServices;

namespace VerificaTed60526
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Esercizio C: Messaggi sospetti

            using (StreamWriter sr = new StreamWriter("messaggi_sospetti.csv"))
            using (StreamReader sw = new StreamReader("messaggi.csv"))
            {
                string riga = sw.ReadLine();

                while (riga != null)
                {

                    if (riga.Contains("Vinci") || riga.Contains("Offerta") || riga.Contains("Compra"))
                    {
                        if (true)
                        {
                            sr.WriteLine(riga);
                        }
                    }

                    riga = sw.ReadLine();

                }

            }

            //Esercizio A: Estrazioni del lotto

            List<string> Ruote = new List<string>() { "bari", "Cagliari", "Firenze", "Genova", "Milano", "Napoli",
                                                      "Palermo", "Roma", "Torino", "Venezia" , "Nazionale"};
            Random estrazione = new Random();

            using (StreamWriter rr = new StreamWriter("estrazioni.csv"))
            {

                rr.WriteLine("ruota,n1,n2,n3,n4,n5");

                foreach (string nazioni in Ruote)
                {
                    rr.Write(nazioni + ",");
                    for (int i = 0; i < 5; i++)
                    {
                        rr.Write(estrazione.Next(0, 90) + ",");
                    }
                    rr.WriteLine();
                }

            }

            //Esercizio B: Verifica delle giocate vincenti
            using (StreamWriter rr = new StreamWriter("estrazioni.csv"))
            {

            }
        }
    }
}
