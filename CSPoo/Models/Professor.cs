using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Professor:Pessoa
    {
        public Professor(string nome): base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        public sealed override void Apresentar(){
            //método selado significa que esse método não pode ser sobrescrito, igual o metodo final do java
            System.Console.WriteLine($"Olá sou {Nome}, um professor de {Idade} anos e recebo {Salario:C}.");
        }
    }
}