using System;

namespace _20_06
{
    internal class Operazione
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string ConfermaPassword { get; set; }
        public bool IsLoggedIn { get; set; }
        private bool _isLoggedIn = false;

        public static int _accessi = 0;
        private DateTime? LastLoginTime { get; set; }

        public void Benvenuto()
        {
            Console.WriteLine("Benvenuto, " + Username);
            Console.WriteLine("Digita 1 per fare il login");
            Console.WriteLine("Digita 2 per fare il logout");
            Console.WriteLine("Digita 3 per verificare il numero di accessi");
            Console.WriteLine("Digita 4 per uscire");

            int scelta = int.Parse(Console.ReadLine());
            if (scelta == 1)
            {
                Login();
            }
            else if (scelta == 2)
            {
                Logout();
            }else if (scelta == 3)
            {
                Console.WriteLine("Il numero di accessi è: " + _accessi);
                Benvenuto();
            }
            else if (scelta == 4)
            {
                Esci();
            }
            else
            {
                Console.WriteLine("Scelta non valida");
                Benvenuto();
            }
        }

        public void Login()
        {
            if (_isLoggedIn == false)
            {
                Console.WriteLine("Inserisci il tuo username:");
                string username = Console.ReadLine();
                Console.WriteLine("Inserisci la tua password:");
                string password = Console.ReadLine();
                Console.WriteLine("Conferma la tua password:");
                string confermaPassword = Console.ReadLine();

                if (password == confermaPassword)
                {
                    _isLoggedIn = true;
                    Username = username;
                    Password = password;
                    ConfermaPassword = confermaPassword;
                    LastLoginTime = DateTime.Now;
                    Console.WriteLine("Login avvenuto con successo - " + LastLoginTime.Value);
                    _accessi++;
                    Benvenuto();
                }
                else
                {
                    Console.WriteLine("Le password non coincidono, riprova");
                    Login();
                }
            }
            else
            {
                Console.WriteLine("Sei già loggato");
                Benvenuto();
            }
        }

        public void Logout()
        {
            if (_isLoggedIn == true)
            {
                _isLoggedIn = false;
                Username = null;
                Password = null;
                ConfermaPassword = null;
                Console.WriteLine("Logout effettuato con successo");
                Benvenuto();
            }
            else
            {
                Console.WriteLine("Non sei loggato");
                Benvenuto();
            }
        }
        public void NumeroAccessi()
        {
            Console.WriteLine("Il numero di accessi è: " + _accessi);
            Benvenuto();
        }
        public void Esci()
        {
            Console.WriteLine("Arrivederci");
        }
    }
}
