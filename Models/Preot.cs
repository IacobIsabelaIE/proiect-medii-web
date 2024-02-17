using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Preot
    {

        public int ID { get; set; }


        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]*$", ErrorMessage =
"Numele trebuie să înceapă cu majusculă. Exemplu: Pop")]
        public string Nume { get; set; }

        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]*$", ErrorMessage =
"Prenumele trebuie să înceapă cu majusculă. Exemplu: Ion")]
        public string Prenume { get; set; }

        [Display(Name = "Nume")]
        public string? FullName
        {
            get
            {
                return Nume + " " + Prenume;
            }
        }



        [Display(Name = "Data nasterii")]
        public DateTime DataNasterii { get; set; }




        public ICollection<Programare>? Programari { get; set; }






    }
}
