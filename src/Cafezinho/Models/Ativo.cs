using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Ativos")]
    public class Ativo
    {
        [Key]
        [Column(name: "ativo_id")]
        public int AtivoId { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Ticker é obrigatorio")]
        [Column(name: "ticker")]
        public string Ticker { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo Preço é obrigatorio")]
        [Column(name: "preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
