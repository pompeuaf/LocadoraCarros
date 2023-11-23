using System.ComponentModel.DataAnnotations;

namespace LocadoraBack.Models
{
    public class TelefoneEntidade
    {
        public long Id { get; set; }
        public string Numero { get; set; }
        public string DDD { get; set; }

        public long PessoaId { get; set; }
        public PessoaModel Pessoa { get; set; }
    }
}
