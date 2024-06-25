namespace Console25_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Compilazione del CV
            CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Mario",
                    Cognome = "Rossi",
                    Telefono = "1234567890",
                    Email = "mario.rossi@example.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Informatica",
                        Istituto = "Università di Roma",
                        Tipo = "Universitario",
                        Dal = new DateTime(2015, 10, 1),
                        Al = new DateTime(2018, 7, 15)
                    },
                    new Studi
                    {
                        Qualifica = "Diploma di Maturità",
                        Istituto = "Liceo Scientifico Galileo Galilei",
                        Tipo = "Secondario",
                        Dal = new DateTime(2010, 9, 1),
                        Al = new DateTime(2015, 6, 30)
                    }
                },
                Impieghi = new List<Impiego>
                {
                    new Impiego
                    {
                        Esperienze = new Esperienza
                        {
                            Azienda = "Tech Solutions",
                            JobTitle = "Software Developer",
                            Dal = new DateTime(2018, 9, 1),
                            Al = new DateTime(2021, 12, 31),
                            Descrizione = "Sviluppo di applicazioni web",
                            Compiti = new List<string>
                            {
                                "Analisi dei requisiti",
                                "Sviluppo del codice",
                                "Test e manutenzione"
                            }
                        }
                    },
                    new Impiego
                    {
                        Esperienze = new Esperienza
                        {
                            Azienda = "InnovaTech",
                            JobTitle = "Senior Developer",
                            Dal = new DateTime(2022, 1, 1),
                            Al = DateTime.Now, // Al momento attuale
                            Descrizione = "Gestione di progetti di sviluppo software",
                            Compiti = new List<string>
                            {
                                "Coordinamento del team di sviluppo",
                                "Progettazione dell'architettura software",
                                "Revisione del codice",
                                "Supporto e formazione dei nuovi membri del team"
                            }
                        }
                    }
                }
            };

            // Stampa del CV
            StampaDettagliCVSuSchermo(mioCV);
        }

        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine("++++ Informazioni Personali: ++++");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine("++++ FINE Informazioni Personali ++++");
            Console.WriteLine();

            Console.WriteLine("Studi Effettuati:");
            foreach (var studi in cv.StudiEffettuati)
            {
                Console.WriteLine($"Qualifica: {studi.Qualifica}");
                Console.WriteLine($"Istituto: {studi.Istituto}");
                Console.WriteLine($"Tipo: {studi.Tipo}");
                Console.WriteLine($"Dal: {studi.Dal.ToShortDateString()} Al: {studi.Al.ToShortDateString()}");
                Console.WriteLine();
            }

            Console.WriteLine("Impieghi:");
            foreach (var impiego in cv.Impieghi)
            {
                var esperienza = impiego.Esperienze;
                Console.WriteLine($"Azienda: {esperienza.Azienda}");
                Console.WriteLine($"Job Title: {esperienza.JobTitle}");
                Console.WriteLine($"Dal: {esperienza.Dal.ToShortDateString()} Al: {esperienza.Al.ToShortDateString()}");
                Console.WriteLine($"Descrizione: {esperienza.Descrizione}");
                Console.WriteLine("Compiti:");
                foreach (var compito in esperienza.Compiti)
                {
                    Console.WriteLine($"- {compito}");
                }
                Console.WriteLine();
            }
        }
    }
}
