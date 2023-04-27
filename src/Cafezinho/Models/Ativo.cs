using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Ativos")]
    public class Ativo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Ticker é obrigatorio")]
        public string Ticker { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(18,2)")]
        [Required(ErrorMessage = "Campo Preço é obrigatorio")]
        public decimal Preco { get; set; }
    }
}
