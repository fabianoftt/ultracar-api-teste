namespace Ultracar.Domain.Entities
{
    public class Modelo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int MarcaId { get; private set; }

        protected Modelo() { }

        public Modelo(string nome, int marcaId)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome do modelo é obrigatório.");

            if (marcaId <= 0)
                throw new ArgumentException("Nome do modelo é obrigatório.");

            Nome = nome;
            MarcaId = marcaId;
        }
    }
}
