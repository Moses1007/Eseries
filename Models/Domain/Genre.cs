using System.ComponentModel.DataAnnotations;

namespace Eseries.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        
        [Required]
        public string? Genrename { get; set; }
    }
}
