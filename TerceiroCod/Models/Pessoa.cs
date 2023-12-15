using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerceiroCod.Models
{
    public class Pessoa
    {
        //a diferença entre prop e outros campos é que as prorpiedades tem get e/ou set
        private int _idade;
        private string _nome;
        public string Nome 
        { 
            // get
            // {
            //     return _nome.ToUpper();
            // } ou posso resumir com uma body expression:
            get => _nome.ToUpper();
            //poderia fazer a mesma coisa no set se não tivesse a validação
            // set => _nome = value
            set
            {  
                if(value==""){
                    throw new ArgumentException("o nome não pode estar vazioo");
                }
                //se o nome estiver vazio ele vai encerra e mostar a exceção, 
                //senão vai executar a linha abaixo
                _nome = value;
            } 
        }
        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value<0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();//prop somente leitura

        public void Apresentar(){
            Console.WriteLine($"nome - {NomeCompleto}, idade - {_idade}");
        }
        
    }
}