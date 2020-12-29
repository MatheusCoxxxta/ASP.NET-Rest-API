using System.ComponentModel.DataAnnotations;

namespace server.Models
{
  public class Category
  {
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Este campo é obirgatório.")]
    [MaxLength(60, ErrorMessage = "Este campo deve conter no máximo 60 caracteres.")]
    [MinLength(3, ErrorMessage = "Este campo deve conter no máximo 60 caracteres.")]

    public string Title { get; set; }
  }
}
