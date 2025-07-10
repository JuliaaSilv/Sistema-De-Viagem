using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agencia.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; } = 0;
        [Required]
        public string Nome { get; set; } = string.Empty;
        [Required]
        [Column(TypeName = "varchar(11)")]        
        public string Cpf { get; set; } = string.Empty;
        [Required]
        public string Telefone { get; set; } = string.Empty;
        [Required]
        public DateTime DataNascimento { get; set; } = DateTime.Now;
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Senha { get; set; } = string.Empty;
        [Required]
        public TipoUsuario Tipo { get; set; }
  
    }
}