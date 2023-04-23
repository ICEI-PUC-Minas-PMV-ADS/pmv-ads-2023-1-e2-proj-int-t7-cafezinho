using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Campo CPF é obrigatório.")]
        [Display(Name ="CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [DataType(DataType.Date)]
        [Display(Name ="Data de nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 8)]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Estado { get; set; }        

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Column(name: "id_carteira")]
        [ForeignKey("IdCarteira")]
        public string? IdCarteira { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [Display(Name ="Perfil de usuário")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Administrador,
        Usuario
    }
}