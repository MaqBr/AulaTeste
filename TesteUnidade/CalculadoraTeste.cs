using System;
using Xunit;
using UI;

namespace TesteUnidade
{
    public class CalculadoraTeste
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(2, 2);
            //Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void Calculadora_Dividir_RetornarValorDivisao() {

            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Dividir(10, 2);
            //Assert
            Assert.Equal(5, resultado);

        }


        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(3, 2, 5)]
        [InlineData(4, 2, 6)]
        public void Calculadora_Somar_RetornarValoresSomaCorretas(double v1, 
        double v2, double total) {

            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(v1, v2);
            //Assert
            Assert.Equal(total, resultado);
        }

        // 5/0 = Erro
        [Fact]
        public void Calculadora_Dividir_DeveRetornarErroDivisaoPorZero()
        {
            // Arrange
            var calculadora = new Calculadora();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculadora.Dividir(5, 0));
        }

        // 10/2 =5
        // 8/2 = 4
        // 6/2 = 3 
        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(8, 2, 4)]
        [InlineData(6, 2, 3)]
        public void Calculadora_Dividir_RetornarValoresDivisaoCorretas(int v1, 
        int v2, double total) {

            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Dividir(v1, v2);
            //Assert
            Assert.Equal(total, resultado);
        }


    }
}
