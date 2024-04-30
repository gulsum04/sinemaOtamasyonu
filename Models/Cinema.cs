using sinemaOtamasyonu.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace sinemaOtamasyonu.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        [Required(ErrorMessage = "Sinema Logosu giriniz!")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Sinema adı giriniz!")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Adres giriniz!")]
        public string Description { get; set; }
        //ilişkiler
        public List<Movie>? Movies { get; set; }
    }
}
