using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; } = 0;
        public int NumeroReserva { get; set; } = 0;
        public DateTime DataReserva { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public float ValorUnitario { get; set; } = 0.0f;

        public Usuario Usuario { get; set; } = new Usuario();
        public Pacote Pacote { get; set; } = new Pacote();
        public List<Viajante> Viajantes { get; set; } = new List<Viajante>();
    }
}