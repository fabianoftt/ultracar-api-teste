using Ultracar.Domain.Enums;

namespace Ultracar.Domain.Entities
{
    public class OrcamentoItem
    {
        protected OrcamentoItem()
        {

        }

        public int Id { get; private set; }
        public int OrcamentoId { get; private set; }

        public TipoItem Tipo { get; private set; }

        public int ReferenciaId { get; private set; }

        public int? ItemPaiId { get; private set; }

        public string? Descricao { get; private set; }
        public int Quantidade { get; private set; }
        public decimal ValorUnitario { get; private set; }

        public DecisaoItem Decisao { get; private set; }
    }
}
