using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{
    [Required(ErrorMessage = "Opa, esqueceu de informar o nome do filme")]
    [StringLength(500)]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "Opa, esqueceu de informar o genero do filme")]
    [StringLength(50)]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A Duração do filme é obrigatorio")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600")]
    public int Duracao { get; set; }
}
