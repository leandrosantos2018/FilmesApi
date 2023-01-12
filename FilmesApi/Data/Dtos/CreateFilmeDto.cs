using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos
{
    public class CreateFilmeDto
    {
      
        [Required(ErrorMessage = "o Titulo do Filme é obrigatório")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "genero do filme é obrigatório")]
        public string Descricao { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "o  Tamnho do Gênero não pode exceder 50")]
        public string Tipo { get; set; }

        [Required]
        [Range(70, 600, ErrorMessage = "a Duração do filme deve ser 70 e 600 minutos")]
        public int Duracao { get; set; }
    }
}
