using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Registros")]
    public class Registro
    {
        [Key]
        [Column(name: "registro_id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Ticker é obrigatorio")]
        [Column(name: "ticker")]
        public string Ticker { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo Preço é obrigatorio")]
        [Column(name: "preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        [Column(name: "quantidade", TypeName = "decimal(18,2)")]
        public decimal Quantidade { get; set; }

        [Column(name: "tipo_transacao")]
        public string TipoTransacao { get; set; }

        [Column(name: "data_transacao")]
        public DateTime DataTransacao { get; set; }

        [Column(name: "valor_total", TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
    }
}
