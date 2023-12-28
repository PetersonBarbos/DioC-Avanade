using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;
        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }
        [Fact] // - é necessario o [Fact]
        public void DeveContar3CaracteresEmOlaERetornar3(){
            //Arrange
            string texto = "olá";
            //Act
            int resultado = _validacoes.ContarCaracteres(texto);
            //Assert
            Assert.Equal(3,resultado);
        }
    }
}