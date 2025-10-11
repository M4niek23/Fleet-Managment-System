using System.ComponentModel.DataAnnotations;

namespace Fleet_Managment.Models
{
    public class Vehicle
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage ="Pole 'Marka' jest wymagane")]
        [StringLength(50)]
        [Display(Name ="Marka")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Pole 'Model' jest wymagane")]
        [StringLength(50)]
        [Display(Name = "Model")]
        public string Model { get; set; }

        [Required(ErrorMessage = "Pole 'Numer rejestracyjny' jest wymagane")]
        [StringLength(15)]
        [Display(Name = "Numer rejestracyjny")]
        public string RegistrationNumber { get; set; }

        [Required(ErrorMessage = "Pole 'Rok produkcji' jest wymagane")]
        [Range(1900, 2100, ErrorMessage = "Wskaż prawidłowy rok produkcji")]
        [Display(Name = "Rok produkcji")]
        public int ProductionYear { get; set; }
    }
}
