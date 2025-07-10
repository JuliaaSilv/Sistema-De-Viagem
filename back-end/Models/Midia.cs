using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Midia
    {
        [Key]
        public int Id { get; set; } = 0;
        public string Tipo { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public Pacote Pacote { get; set; }
        public List<Midia> Midias { get; set; } = new List<Midia>();
    }
}