using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("Carteira")]
    public class Carteira
    {
        [Key]
        [Column(name: "id")]
        public int Id { get; set; }

        [Display(Name = "Valor Total da Carteria")]
        [Column(name: "valor total carteira", TypeName = "Decimal(18,2)")]
        public decimal valorTotalCarteira { get; set; }
    }
}
