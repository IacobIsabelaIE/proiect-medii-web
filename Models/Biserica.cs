using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Biserica
    {
        public int ID { get; set; }



        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]*$", ErrorMessage =
"Numele bisericii trebuie sa inceapa cu majuscula. Nu se permit caracterele speciale. Exemplu: Sfantul Ioan Botezatorul")]


        public string Nume { get; set; }


        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]*$", ErrorMessage =
"Localitatea trebuie să înceapă cu majusculă. Exemplu: Cluj-Napoca")]


        public string Localitate { get; set; }

        [StringLength(70)]


        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]{0,50}$", ErrorMessage =
"Strada trebuie să înceapă cu majusculă și să nu depășească 50 de caractere. Exemplu: Cireselor")]

        public string Strada { get; set; }


        [RegularExpression(@"^\d+$", ErrorMessage = "Numarul trebuie să fie un număr întreg.")]
        public string Numar { get; set; }


        public ICollection<Programare>? Programari { get; set; }
    }
}
