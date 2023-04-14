using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;


namespace src.Models
{

    [Table("clientes")]
    [PrimaryKey(nameof(Cpf))]
    public class Cliente
    {

        [Key]
        [Required(ErrorMessage = "Campo Cpf é obrigatorio.")]
        [Column(name: "cpf")]
        public string Cpf { get; set; }
        [Required(ErrorMessage = "Campo Email é obrigatorio.")]
        [Column(name: "email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Campo Cep é obrigatorio.")]
        [Column(name: "cep")]
        public string Cep { get; set; }
        [Required(ErrorMessage = "Campo Endereco é obrigatorio.")]
        [Column(name: "endereco")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Campo Data de nascimento é obrigatorio.")]
        [DataType(DataType.Date)]
        [Column(name: "dt_nascimento")]
        public DateTime DtNascimento { get; set; }
        [Required(ErrorMessage = "Campo senha é obrigatorio.")]
        [Column(name: "senha")]
        private string _senha { get; set; }
        [Column(name: "carteira_id")]
        
        [ForeignKey("CarteiraId")]
        public string? CarteiraId { get; set; }
        
        
        public void SetSenha(string senha)
        {
            // aqui deve se criptografar a senha
            this._senha = senha; 
        }

    }
}
