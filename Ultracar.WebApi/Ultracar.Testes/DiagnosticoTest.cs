using Ultracar.Domain.Entities;
using Ultracar.Domain.Enums;

namespace Ultracar.Tests
{
    public class DiagnosticoTests
    {
        [Fact]
        public void Diagnostico_ValidarParametros_DeveCriarObjeto()
        {
            string codigo = "D001";
            string descricao = "Falha no sistema de ignição";
            TipoSistema sistema = TipoSistema.Motor;

            var diagnostico = new Diagnostico(codigo, descricao, sistema);

            Assert.Equal(codigo, diagnostico.Codigo);
            Assert.Equal(descricao, diagnostico.Descricao);
            Assert.Equal(sistema, diagnostico.Sistema);
        }

        [Fact]
        public void Diagnostico_CodigoVazio_DeveDevolverException()
        {
            string codigo = "";
            string descricao = "Falha no sistema elétrico";

            var ex = Assert.Throws<ArgumentException>(() =>
                new Diagnostico(codigo, descricao, TipoSistema.Motor));

            Assert.Equal("Código é obrigatório.", ex.Message);
        }

        [Fact]
        public void Diagnostico_DescricaoVazio_DeveDevolverException()
        {
            string codigo = "D002";
            string descricao = "";

            var ex = Assert.Throws<ArgumentException>(() =>
                new Diagnostico(codigo, descricao, TipoSistema.Freio));

            Assert.Equal("Descrição é obrigatória.", ex.Message);
        }
    }
}