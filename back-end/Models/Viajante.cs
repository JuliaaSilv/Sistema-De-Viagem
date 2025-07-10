using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Viajante
    {
        [Key]
        public int Id { get; set; } = 0;
        public string Nome { get; set; } = string.Empty;
        public string Documento { get; set; } = string.Empty; 
        public string Passaporte { get; set; } = string.Empty;

        public Reserva Reserva { get; set; } 
    }
}