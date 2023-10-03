using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Models;

public class Filme
{
    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage = "O titulo do filme é obrigatorio")]
    [MaxLength(500)]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O Genero do filme é obrigatorio")]
    [MaxLength(50)]
    public string Genero { get ; set;}
    [Required(ErrorMessage = "A Duração do filme é obrigatorio")]
    [Range(70, 600, ErrorMessage = "A duração do filme deve ser entre 70 e 600")]
    public int Duracao { get ; set;}

}
