using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.Dtos;

public class CreateFilmeDto
{
    [Required(ErrorMessage = "O titulo do filme é obigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obigatório")]
    [StringLength(50, ErrorMessage = "O tamanho do gênero nao pode exceder 50 caracteres")]
    public string Genero { get; set; }
    [Required(ErrorMessage = "A duração do filme é obigatório")]
    [Range(70, 600, ErrorMessage = "A duração deve ter entre 70 e 600")]
    public int Duracao { get; set; }
}