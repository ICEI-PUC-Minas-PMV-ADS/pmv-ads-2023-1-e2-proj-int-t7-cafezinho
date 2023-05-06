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
        public int RegistroId { get; set; }

        [Required(ErrorMessage = "Campo Ticker é obrigatorio")]
        [Column(name: "ticker")]
        public string Ticker { get; set; }

        [Display(Name = "Preço")]
        [Required(ErrorMessage = "Campo Preço é obrigatorio")]
        [Column(name: "preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Campo Quantidade é obrigatorio")]
        [Column(name: "quantidade")]
        public int Quantidade { get; set; }

        [Column(name: "tipo_transacao")]
        [Required(ErrorMessage = "Campo Transação é obrigatorio")]
        [Display(Name = "Tipo de transação")]
        public Transacao Transacao { get; set; }

        [Column(name: "data_transacao")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da transação")]
        public DateTime DtTransacao { get; set; }

        [Column(name: "valor_total", TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }
    }

    public enum Transacao
    {
        Compra,
        Venda
    }
}
