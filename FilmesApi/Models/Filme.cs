using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Models
{
    public class Filme
    {
        [Key]
        [Required]
        public int Id  { get; set; }

        [Required(ErrorMessage ="o Titulo do Filme é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "genero do filme é obrigatório")]
        public string Descricao { get; set; }
        
        [Required]
        [MaxLength(50,ErrorMessage ="o  Tamnho do Gênero não pode exceder 50")]
        public string Tipo { get; set; }

        [Required]
        [Range(70,600, ErrorMessage ="a Duração do filme deve ser 70 e 600 minutos")]
        public int Duracao { get; set; }

    }
}
