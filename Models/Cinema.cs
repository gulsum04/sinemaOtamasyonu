using System.ComponentModel.DataAnnotations;

namespace sinemaOtamasyonu.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }

        [Display(Name = "Cinema Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
        //ilişkiler
        public List<Movie> Movies { get; set; }
    }
}
