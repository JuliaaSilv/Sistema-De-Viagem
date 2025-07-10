using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agencia.Models
{
    public class Pacote
    {
        [Key]
        public int Id { get; set; } = 0;
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Destino { get; set; } = string.Empty;
        public int Duracao { get; set; } = 0;
        public DateTime DataDisponivel { get; set; } = DateTime.Now;
        public float ValorTotal { get; set; } = 0.0f;
    }
}
