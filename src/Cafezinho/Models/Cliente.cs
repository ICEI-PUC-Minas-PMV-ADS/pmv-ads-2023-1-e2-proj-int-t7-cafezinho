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
        [Column(name: "cpf")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório.")]
        [Display(Name ="E-mail")]
        [Column(name: "email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Data de nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        [Display(Name ="Data de nascimento")]
        [Column(name: "dt_nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "O campo CEP é obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 8)]
        [Column(name: "cep")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O campo Logradouro é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Column(name: "logradouro")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "O campo Numero é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 1)]
        [Column(name: "numero")]
        public string Numero { get; set; }

        public string Complemento { get; set; }

        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Column(name: "bairro")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "O campo Cidade é obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Column(name: "cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "O campo Estado é obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        [Column(name: "estado")]
        public string Estado { get; set; }        

        [Required(ErrorMessage = "Campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Column(name: "senha")]
        public string Senha { get; set; }

        [ForeignKey("CarteiraId")]
        [Column(name: "carteira_id")]
        public string? CarteiraId { get; set; }

        [Required(ErrorMessage = "Campo Perfil de usuário é obrigatório.")]
        [Display(Name ="Perfil de usuário")]
        [Column(name: "perfil")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Usuario,
        Administrador
    }
}