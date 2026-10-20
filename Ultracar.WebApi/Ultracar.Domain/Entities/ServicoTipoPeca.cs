namespace Ultracar.Domain.Entities
{
    public class ServicoTipoPeca
    {
        protected ServicoTipoPeca() { }

        public int ServicoId { get; set; }
        public int TipoPecaId { get; set; }
        public int QuantidadePadrao { get; set; }

        public Servico Servico { get; set; }
    }
}
