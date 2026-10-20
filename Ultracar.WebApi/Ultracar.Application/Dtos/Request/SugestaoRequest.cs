namespace Ultracar.Application.Dtos.Request
{
    public class SugestaoRequest
    {
        public int VeiculoId { get; set; }
        public List<int> DiagnosticoIds { get; set; } = new List<int>();
    }
}
