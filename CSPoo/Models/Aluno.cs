using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public sealed class Aluno:Pessoa // : equivale ao extends do java
    // sealed equivale a final no java, assim como classe selada equivale a classe final
    {
        public Aluno(string nome):base(nome)
        {
            
        }
        public double Nota { get; set; }
        public override void Apresentar(){
            System.Console.WriteLine($"Olá sou {Nome}, um aluno de {Idade} anos e sou nota {Nota}.");
        }
    }
}