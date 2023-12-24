using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Aluno:Pessoa // : equivale ao extends do java
    {
        public double Nota { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá sou {Nome}, um aluno de {Idade} anos e sou nota {Nota}.");
        }
    }
}