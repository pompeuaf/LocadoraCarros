using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraBack.Models
{
    public class PedidoModel
    {
        public int Id { get; set; }
        public long PessoaId { get; set; }
        public PessoaModel Pessoa { get; set; }
        public long VeiculoId { get; set; }
        public VeiculoModel Veiculo { get; set; }
        public decimal valor { get; set; }
        public DateTime data_locacao { get; set; }
        public DateTime data_retirada { get; set; }
        public DateTime data_devolucao { get; set; }
        public string forma_pgto { get; set; }
        public int status { get; set; }
        public bool ativo { get; set; }


    }
}
