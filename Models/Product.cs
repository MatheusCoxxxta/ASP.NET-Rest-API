using System.ComponentModel.DataAnnotations;

namespace server.Models
{
  public class Product
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Este campo é obirgatório.")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter no máximo 60 caracteres.")]
    [MinLength(3, ErrorMessage = "Este campo deve conter no máximo 60 caracteres.")]

    public string Title { get; set; }

    [MaxLength(1024, ErrorMessage = "Este campo deve conter no máximo 1024 caracteres.")]

    public string Description { get; set; }

    [Required(ErrorMessage = "Este campo é obirgatório.")]
    [Range(1, int.MaxValue, ErrorMessage = "Categoria inválida")]
    public int CategoryId { get; set; }
    public string Category { get; set; }

  }
}
