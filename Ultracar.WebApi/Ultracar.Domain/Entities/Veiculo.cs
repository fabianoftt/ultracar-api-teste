namespace Ultracar.Domain.Entities
{
    namespace Ultracar.Domain.Entities
    {
        public class Veiculo
        {
            protected Veiculo() { }

            public int Id { get; private set; }
            public string Placa { get; private set; }
            public int MarcaId { get; private set; }
            public int ModeloId { get; private set; }
            public int Ano { get; private set; }

            public Veiculo(string placa, int marcaId, int modeloId, int ano)
            {
                if (string.IsNullOrWhiteSpace(placa))
                    throw new ArgumentException("Placa é obrigatória.");

                if (marcaId <= 0)
                    throw new ArgumentException("Marca é obrigatório.");

                if (modeloId <= 0)
                    throw new ArgumentException("Modelo é obrigatório.");

                if (ano <= 0)
                    throw new ArgumentException("Ano é obrigatório.");

                Placa = placa;
                MarcaId = marcaId;
                ModeloId = modeloId;
                Ano = ano;
            }
        }
    }
}
