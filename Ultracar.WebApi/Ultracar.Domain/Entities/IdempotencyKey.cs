namespace Ultracar.Domain.Entities
{
    public class IdempotencyKey
    {
        protected IdempotencyKey()
        {
            
        }

        public int Id { get; private set; }
        public string Chave { get; private set; }
        public int OficinaId { get; private set; }
        public string Rota { get; private set; }
        public string HashRequest { get; private set; }
        public string RespostaJson { get; private set; }
        public DateTime CriadoEm { get; private set; }
    }
}
