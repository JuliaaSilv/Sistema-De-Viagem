using System.ComponentModel.DataAnnotations;

namespace agencia.Models
{
    public class Promocao
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public float DescontoPercentual { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public List<Pacote> Pacotes { get; set; }
    }
}
