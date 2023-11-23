using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraBack.Models
{
    public class PessoaModel
    {
        public long Id { get; set; }
        public int pessoa_tipo { get; set; }
        public string cpfcnpj { get; set; }
        public string pessoa { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public bool pessoa_act { get; set; }

    }
}