using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Calculadora;

namespace TestCalculadora
{
    public class UnitTest1
    {
        public CalculadoraTest construirClasse()
        {
            string data = "02/02/2020";
            CalculadoraTest calc = new CalculadoraTest(data);

            return calc;
        }


        [Theory]
        [InlineData (1, 2, 3)]
        [InlineData (4, 5, 9)]
        public void TesteSomar(int val1, int val2, int resultado)
        {
            CalculadoraTest calc = construirClasse();

            int resuladoCalculadora = calc.somar(val1, val2);

            Assert.Equal(resultado, resuladoCalculadora);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void TesteMultiplicar(int val1, int val2, int resultado)
        {
            CalculadoraTest calc = construirClasse();

            int resuladoCalculadora = calc.multiplicar(val1, val2);

            Assert.Equal(resultado, resuladoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 3)]
        [InlineData(5, 5, 1)]
        public void TesteDividir(int val1, int val2, int resultado)
        {
            CalculadoraTest calc = construirClasse();

            int resuladoCalculadora = calc.dividir(val1, val2);

            Assert.Equal(resultado, resuladoCalculadora);
        }

        [Theory]
        [InlineData(6, 2, 4)]
        [InlineData(10, 5, 5)]
        public void TesteSubtrair(int val1, int val2, int resultado)
        {
            CalculadoraTest calc = construirClasse();

            int resuladoCalculadora = calc.subtrair(val1, val2);

            Assert.Equal(resultado, resuladoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            CalculadoraTest calc = construirClasse();

            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            CalculadoraTest calc = construirClasse();

            calc.somar(1, 2);
            calc.somar(1, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}
