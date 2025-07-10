using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace agencia.Models
{
   
    public class TipoDocumento
    {
        [Key]
        public int Id { get; set; }
        public string TipoDocumentoNome { get; set; }
        public string NumeroDocumento { get; set; }

        public Usuario Usuario { get; set; }
    }
}
