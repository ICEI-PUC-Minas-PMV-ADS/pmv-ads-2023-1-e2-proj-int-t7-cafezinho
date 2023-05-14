
using Cafezinho.Models;

namespace Cafezinho.ViewModels

{

    public class CreateRegistroViewModel
    {

        public string AtivoId { get; set; }

        public decimal Preco { get; set; }

        public int Quantidade { get; set; }


        public Transacao Transacao { get; set; }


        public DateTime DtTransacao { get; set; }


        public decimal ValorTotal { get; set; }

        public List<Ativo> Ativos { get; set; }


    }


}
