using Ultracar.Domain.Entities.Ultracar.Domain.Entities;
using Ultracar.Domain.Enums;

namespace Ultracar.Domain.Entities
{
    public class Orcamento
    {
        protected Orcamento() { }

        public int Id { get; private set; }
        public int OficinaId { get; private set; }
        public int OrdemServicoId { get; private set; }
        public int VeiculoId { get; private set; }
        public int ClienteId { get; private set; }

        public StatusOrcamento Status { get; private set; }
        public int Versao { get; private set; }

        public byte[] RowVersion { get; private set; }

        public string TokenPublico { get; private set; }
        public DateTime TokenExpiraEm { get; private set; }

        public int EnviadoPor { get; private set; }
        public DateTime? EnviadoEm { get; private set; }

        public decimal Total { get; private set; }
        public decimal? ValorAprovado { get; private set; }

        public Veiculo Veiculo { get; private set; }

        public ICollection<OrcamentoItem> Itens { get; private set; }
        public ICollection<OrcamentoHistorico> Historicos { get; private set; }

        public Orcamento(int oficinaId, int ordemServicoId, int veiculoId, int clienteId, StatusOrcamento status, decimal total)
        {
            OficinaId = oficinaId;
            OrdemServicoId = ordemServicoId;
            VeiculoId = veiculoId;
            ClienteId = clienteId;
            Status = status;
            Versao = 1;
            Total = total;
            TokenPublico = Guid.NewGuid().ToString("N");
            TokenExpiraEm = DateTime.Now.AddDays(7);
        }
    }
}