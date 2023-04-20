using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    [Table("clientes")]
    // [PrimaryKey(nameof(Cpf))]
    public class Cliente
    {
        [Key]
        [Required(ErrorMessage = "Campo CPF é obrigatório.")]
        [Column(name: "cpf")]
        [Display(Name ="CPF")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo E-mail é obrigatório.")]
        [Column(name: "email")]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório.")]
        [Column(name: "nome")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo CEP é obrigatório.")]
        [Column(name: "cep")]
        [Display(Name ="CEP")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Campo Endereço é obrigatório.")]
        [Column(name: "endereco")]
        [Display(Name ="Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo Data de nascimento é obrigatório.")]
        [DataType(DataType.Date)]
        [Column(name: "dt_nascimento")]
        [Display(Name ="Data de nascimento")]
        public DateTime DtNascimento { get; set; }

        [Required(ErrorMessage = "Campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        [Column(name: "senha")]
        public string Senha { get; set; }

        [Column(name: "carteira_id")]
        [ForeignKey("CarteiraId")]
        public string? CarteiraId { get; set; }

        [Required(ErrorMessage = "Campo Perfil de usuário é obrigatório.")]
        [Display(Name ="Perfil de usuário")]
        public Perfil Perfil { get; set; }
    }

    public enum Perfil
    {
        Administrador,
        Usuario
    }
}