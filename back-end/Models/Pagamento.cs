using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Pagamento
    {
        [Key]
        public int Id { get; set; } = 0;
        public float Valor { get; set; } = 0.0f;
        public FormaDePagamento FormaDePagamento { get; set; } 
        public DateTime DataPagamento { get; set; } = DateTime.Now;
        public StatusPagamento StatusPagamento { get; set; } = StatusPagamento.Pendente;
        public Reserva Reserva { get; set; }
    }
}