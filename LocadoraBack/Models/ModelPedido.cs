namespace LocadoraBack.Models
{
    public class ModelPedido
    {
        public int Id { get; set; }
        public long PessoaId { get; set; }
      
        public long VeiculoId { get; set; }
      
        public decimal valor { get; set; }
        public DateTime data_locacao { get; set; }
        public DateTime data_retirada { get; set; }
        public DateTime data_devolucao { get; set; }
        public string forma_pgto { get; set; }
        public int status { get; set; }
        public bool ativo { get; set; }

        public PedidoModel ModelParaEntidade()
        {
            PedidoModel p = new PedidoModel();
            p.forma_pgto = forma_pgto;
            p.status = status;
            p.valor = valor;
            p.VeiculoId = VeiculoId;   
            p.data_locacao = data_locacao;  
            p.data_retirada = data_retirada;
            p.data_devolucao = data_devolucao;
            p.PessoaId = PessoaId;

            return p; 
        }
    }
}
