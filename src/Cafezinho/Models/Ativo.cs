using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Ativos")]
    public class Ativo
    {
        [Required(ErrorMessage = "Campo Nome é obrigatorio")]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Key]
        [Required(ErrorMessage = "Campo Ticker é obrigatorio")]
        [Column(name: "ticker")]
        public string Ticker { get; set; }
    }
}
