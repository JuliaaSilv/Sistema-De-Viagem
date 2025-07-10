using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Avaliacao
    {
        [Key]
        public int Id { get; set; } = 0;
        [Required]
        public int Nota { get; set; } = 0;
        
        public string Comentario { get; set; } = string.Empty;
        [Required]
        public DateTime Data { get; set; } = DateTime.Now;
        [Required]
        public Reserva Reserva { get; set; }
        
    }
}