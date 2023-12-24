using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Professor:Pessoa
    {
        public decimal Salario { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá sou {Nome}, um professor de {Idade} anos e recebo {Salario:C}.");
        }
    }
}