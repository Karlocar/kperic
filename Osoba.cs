using System.ComponentModel.DataAnnotations;
namespace Instagram.Models
{
    public class Osoba : Entitet
    {
        [Required]
        public string? ime { get; set; }
        [Required]
        [Range(30,500)]
        public string? prezime { get; set;}
        public DateTime datumrodenja { get; set; }
        public string? korisnickoime { get; set; }
        public string? lozinka { get; set; }
        public string? slika { get; set; }
    }
}
