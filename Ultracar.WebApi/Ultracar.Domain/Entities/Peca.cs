namespace Ultracar.Domain.Entities
{
    public class Peca
    {
        protected Peca() { }

        public int Id { get; private set; }
        public string CodigoFabricante { get; private set; }
        public string Descricao { get; private set; }
        public int TipoPecaId { get; private set; }
        public decimal Preco { get; private set; }
        public int Preferencia { get; private set; }

        public ServicoTipoPeca TipoPeca
        {
            get; private set;
        }
    }
}