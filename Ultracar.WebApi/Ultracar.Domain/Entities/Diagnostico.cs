using Ultracar.Domain.Enums;

namespace Ultracar.Domain.Entities
{
    public class Diagnostico
    {
        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Descricao { get; private set; }
        public TipoSistema Sistema { get; private set; }

        protected Diagnostico() { }

        public Diagnostico(string codigo, string descricao, TipoSistema sistema)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new ArgumentException("Código é obrigatório.");
            if (string.IsNullOrWhiteSpace(descricao))
                throw new ArgumentException("Descrição é obrigatória.");

            Codigo = codigo;
            Descricao = descricao;
            Sistema = sistema;
        }
    }
}
