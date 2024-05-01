using sinemaOtamasyonu.Data.Base;
using sinemaOtamasyonu.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace sinemaOtamasyonu.Models
{
    public class NewMovieVM
    {
        public int Id { get; set; }

        [Display(Name = "Movie name")]
        [Required(ErrorMessage ="Film ismi giriniz!")]
        public string Name { get; set; }

        [Display(Name = "Movie description")]
        [Required(ErrorMessage = "Film içeriği giriniz!")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Fiyat giriniz!")]
        public double Price { get; set; }

        [Display(Name = "Movie poster URL")]
        [Required(ErrorMessage = "Film görseli giriniz!")]
        public string ImageURL { get; set; }

        [Display(Name = "Select a category")]
        [Required(ErrorMessage = "Film kategorisi seçiniz!")]
        public MovieCategory MovieCategory { get; set; }

        //Relationships

        [Display(Name = "Select a actor(s)")]
        [Required(ErrorMessage = "Aktör seçiniz!")]
        public List<int> ActorIds{ get; set; }

        [Display(Name = "Select a cinema(s)")]
        [Required(ErrorMessage = "Sinema seçiniz!")]
        public int CinemaId { get; set; }

        [Display(Name = "Select a producer(s)")]
        [Required(ErrorMessage = "Yönetmen seçiniz!")]
        public int ProducerId { get; set; }
       
    }
}
