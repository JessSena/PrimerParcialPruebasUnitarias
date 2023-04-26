using primer_parcial_unit_test_procesador_matematico;
using Xunit;

namespace ProcesadorMatematicoTests
{
    public class ProcesadorMatematicoTests
    {
        [Theory]
        [InlineData(1, -1, 0)]
        [InlineData(-2, -2, -4)]
        [InlineData(2, 3, 5)]
        public void SumarDevuelveResultadoEsperado(int a, int b, int resultadoEsperado)
        {
            //arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();
            //act
            int resultadoReal = procesador.Sumar(a, b);
            //assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(4, 2, 2)]
        [InlineData(20, 2, 10)]
        public void DividirDevuelveResultadoEsperado(int a, int b, int resultadoEsperado)
        {
            //arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();
            //act
            int resultadoReal = procesador.Dividir(a, b);
            //assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Theory]
        [InlineData(10, 2, 10)]
        [InlineData(1, 2, 2)]
        [InlineData(20, 2, 20)]
        public void CalcularMayorDevuelveResultadoEsperado(int a, int b, int resultadoEsperado)
        {
            //arrange
            ProcesadorMatematico procesador = new ProcesadorMatematico();
            //act
            int resultadoReal = procesador.CalcularMayor(a, b);
            //assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }



    }
}