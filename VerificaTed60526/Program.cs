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
            using (StreamReader giocate = new StreamReader("giocate_lotto_50.csv"))
            using (StreamWriter finale = new StreamWriter("vincite.csv"))
            {
                giocate.ReadLine();

                string rigaGiocata;

                while ((rigaGiocata = giocate.ReadLine()) != null)
                {
                    string[] parti = rigaGiocata.Split(',');

                    string giocatore = parti[0];
                    string ruota = parti[1];
                    int numero = Convert.ToInt32(parti[2]);

                    using (StreamReader estrazioni = new StreamReader("estrazioni.csv"))
                    {
                        estrazioni.ReadLine();

                        string rigaEstrazione;

                        while ((rigaEstrazione = estrazioni.ReadLine()) != null)
                        {
                            string[] dati = rigaEstrazione.Split(',');

                            if (dati[0] == ruota)
                            {
                                for (int i = 1; i <= 5; i++)
                                {
                                    if (Convert.ToInt32(dati[i]) == numero)
                                    {
                                        finale.WriteLine(giocatore + " ha vinto con il numero " + numero);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}


   