using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Cafezinho.Models
{
    public class Dashboard
    {
        [Key]
        public int DashboardId { get; set; }

        private DateTime dataInicio;
        private DateTime dataFim;
        private int numeroDias;

        public int TotalEmCarteira { get; set; }
        public List<Ativo> ativos { get; set; }
        public List<Registro> Registros { get; set; }
    }
}