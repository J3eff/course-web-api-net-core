using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Endereco
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public virtual Cinema Cinema { get; set; }
    }
}
