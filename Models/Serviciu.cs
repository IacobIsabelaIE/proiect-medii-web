using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Proiect.Models
{
    public class Serviciu
    {
        public int ID { get; set; }


        [RegularExpression(@"^[A-Z][a-zA-Z\s\-]{0,50}$", ErrorMessage =
"Serviciul trebuie să înceapă cu majusculă și să nu depășească 50 de caractere. Exemplu: Botez")]

        [Display(Name = "Serviciu")]
        public string NumeServiciu { get; set; }



        [Display(Name = "Durata")]
        public TimeSpan DurataServiciu { get; set; }


        [Display(Name = "Pret")]
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 800)]
        public decimal PretServiciu { get; set; }

        public ICollection<Programare>? Programari { get; set; }




    }
}
