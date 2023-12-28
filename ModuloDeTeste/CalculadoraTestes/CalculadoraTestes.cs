using Calculadora.services;

namespace CalculadoraTestes;

public class CalculadoraTestes
{
    private Calculadoraimp _calc;

    public CalculadoraTestes()
    {
        _calc = new Calculadoraimp();
    }
    [Fact]
    public void DeveSomar5Com7ERetornar12()
    {
        //Arrange - montar cenário
        int num1 = 5;
        int num2 = 7;
        //act - execução
        int resultado = _calc.Somar(num1, num2);
        //Assert - avalia se retornou o resultado esperado
        Assert.Equal(12,resultado);
        //dotnet test para executar
    }
    [Fact]
    public void DeveAnalisarSe4EParERetornarVerdadeiro(){
        //Arrange
        int num = 4;
        //Act
        bool resultado = _calc.Ehpar(num);
        //Assert
        Assert.True(resultado); // até posso utilizar o .Equal, mas pra bool é mais prático o .True ou .False
    }

    // //Verificando vários números
    // //fact é um cenário só, o theory é um conjunto de cenários que vai passar pelo test
    // [Theory]
    // [InlineData(2)]
    // [InlineData(4)]
    // [InlineData(6)]
    // [InlineData(8)]
    // [InlineData(10)]
    // public void DeveAnalisarSeOsNumerosSaoParERetornarVerdadeiro(int numero){
    //     //Arrange
    //     //Act
    //     bool resultado = _calc.Ehpar(numero);
    //     //Assert
    //     Assert.True(resultado); // até posso utilizar o .Equal, mas pra bool é mais prático o .True ou .False
    // }
    //refatorando para arrays
    [Theory]
    [InlineData(new int[] {2, 4})]
    [InlineData(new int[] {6, 8, 10})]
    public void DeveAnalisarSeOsNumerosDoArraySaoParERetornarVerdadeiro(int[] numeros){
        //Arrange
        //Act
        //Assert
        Assert.All(numeros/*array*/, num/*valor atual do laço*/ => Assert.True(_calc.Ehpar(num)));
        //Assert.All vai fazer uma validação para todos elementos da lista
    }
}