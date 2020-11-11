using System.ComponentModel.DataAnnotations;

namespace testeapi.Models
{
    public class Category
    {
        [Key]
        public int Id { get {return Id;} private set{ } }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        [MaxLength(60, ErrorMessage = "Esse campo deve conter entre 3 e 60 caracteres")]
        public string Title { get; set; }
    }
}