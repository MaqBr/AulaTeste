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

    }
}
