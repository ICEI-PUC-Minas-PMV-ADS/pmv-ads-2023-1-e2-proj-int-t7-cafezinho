using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Vendas")]
    public class Venda
    {
        public Venda(
            decimal Preco,
            int Quantidade,
            DateTime DtTransacao,
            int RegistroId
        )
        {
            this.Preco = Preco;
            this.Quantidade = Quantidade;
            this.DtTransacao = DtTransacao;
            this.RegistroId = RegistroId;
            this.ValorTotal = Quantidade * Preco;
        }

        [Key]
        [Column(name: "venda_id")]
        public int VendaId { get; set; }

        [Column(name: "preco", TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [Column(name: "quantidade")]
        public int Quantidade { get; set; }

        [Column(name: "data_transacao")]
        [DataType(DataType.Date)]
        public DateTime DtTransacao { get; set; }

        [Column(name: "valor_total", TypeName = "decimal(18,2)")]
        public decimal ValorTotal { get; set; }

        [ForeignKey("Registro")]
        [Column(name: "registro_id")]
        public int RegistroId;
        public Registro Registro { get; set; }
    }
}
