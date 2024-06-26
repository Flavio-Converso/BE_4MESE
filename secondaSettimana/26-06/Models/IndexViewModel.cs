namespace _26_06.Models
{
    public class IndexViewModel
    {
        public Persona Persona { get; set; }
        public List<Sala> Sale { get; set; }
        public Biglietto Biglietto { get; set; }

        public IndexViewModel()
        {
            Sale = new List<Sala>
            {
                new Sala { NomeSala = "SalaEst", PostiTotali = 120 },
                new Sala { NomeSala = "SalaSud", PostiTotali = 120 },
                new Sala { NomeSala = "SalaNord", PostiTotali = 120 }
            };
            Biglietto = new Biglietto();
        }
    }
}
