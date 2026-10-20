namespace Ultracar.Domain.Entities
{
    public class Servico
    {
        protected Servico() { }

        public int Id { get; private set; }
        public string Descricao { get; private set; }
        public double TempoPadraoHoras { get; private set; }

        public Servico(string descricao, double tempoPadraoHoras)
        {
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("Descrição é obrigatória.");
            if (tempoPadraoHoras <= 0)
                throw new ArgumentException("Tempo padrão deve ser maior que zero.");

            Descricao = descricao;
            TempoPadraoHoras = tempoPadraoHoras;
        }
    }
}
