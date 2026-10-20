namespace Ultracar.Domain.Entities
{
    public class OrcamentoHistorico
    {
        protected OrcamentoHistorico() { }

        public int Id { get; private set; }
        public int OrcamentoId { get; private set; }
        public string De { get; private set; }
        public string Para { get; private set; }
        public int UsuarioId { get; private set; }
        public string Canal { get; private set; }
        public DateTime Data { get; private set; } 

        public OrcamentoHistorico(int orcamentoId, string de, string para, int usuarioId, string canal)
        {
            if (string.IsNullOrWhiteSpace(de))
                throw new ArgumentException("Campo De é obrigatório.");
            if (string.IsNullOrWhiteSpace(para))
                throw new ArgumentException("Campo Para é obrigatório.");

            OrcamentoId = orcamentoId;
            De = de;
            Para = para;
            UsuarioId = usuarioId;
            Canal = canal;
            Data = DateTime.Now;
        }
    }
}
