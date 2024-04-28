using System.ComponentModel.DataAnnotations;

namespace sinemaOtamasyonu.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Profile Picture")]
        [Required(ErrorMessage ="Profil fotoğrafını giriniz!")]
        public string ProfilePictureURL { get; set; }
         
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Ad soyad giriniz!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Ad soyad 3 ile 50 karakter arasında olmalıdır!")]
        public string FullName { get; set;}

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Biyografi giriniz!")]
        public string Bio { get; set;}

        //ilişkiler
        public List<Actor_Movie>? Actors_Movies{ get; set; }
    }
}
