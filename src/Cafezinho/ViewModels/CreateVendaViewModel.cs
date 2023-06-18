using Cafezinho.Models;

namespace Cafezinho.ViewModels;

public class CreateVendaViewModel
{
    public Registro Registro { get; set; }
    public decimal ValorTotal { get; set; }
    public DateTime DtTransacao { get; set; }

    public decimal Preco { get; set; }

    public int Quantidade { get; set; }

    public int RegistroId { get; set; }

    public int QuantidadeMax { get; set; }
}
