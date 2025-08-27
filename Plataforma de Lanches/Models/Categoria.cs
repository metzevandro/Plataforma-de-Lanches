using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Plataforma_de_Lanches.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Nome da Categoria")]
        [Required(ErrorMessage = "Informe o nome da categoria.")]
        [StringLength(100, ErrorMessage = "O nome da categoria deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "Informe a descrição da categoria.")]
        [StringLength(200, ErrorMessage = "A descrição da categoria deve ter no máximo 200 caracteres.")]
        public string Descricao { get; set; }

        public List<Lanche> Lanches { get; set; }
    }
}
