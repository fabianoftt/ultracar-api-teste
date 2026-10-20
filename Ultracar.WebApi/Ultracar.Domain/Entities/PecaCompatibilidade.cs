namespace Ultracar.Domain.Entities
{
    public class PecaCompatibilidade
    {
        public int PecaId { get; private set; }
        public int ModeloId { get; private set; }
        public int AnoInicio { get; private set; }
        public int AnoFim { get; private set; }

        public Peca Peca { get; private set; }
        public Modelo Modelo { get; private set; }

        protected PecaCompatibilidade() { }

        public PecaCompatibilidade(int pecaId, int modeloId, int anoInicio, int anoFim)
        {
            if (anoInicio > anoFim)
                throw new ArgumentException("Ano início não pode ser maior que ano fim.");

            PecaId = pecaId;
            ModeloId = modeloId;
            AnoInicio = anoInicio;
            AnoFim = anoFim;
        }
    }
}
