
namespace Cafezinho.Models
{
    public class Dashboard
    {
        public int DashboardId { get; set; }
        public int TotalEmCarteira { get; set; }
        public List<Ativo> ativos { get; set; }
        public List<Registro> Registros { get; set; }
    }
}