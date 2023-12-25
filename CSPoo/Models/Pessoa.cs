using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Pessoa
    {
        public Pessoa(string nome)
        //isso vai "quebrar" as classes filhas a não ser que crie um construtor para cada uma
        // e coloque : base(nome), pois vai receber o nome e passar para Pessoa
        //se Pessoa exige nome e Aluno é filho de Pessoa então Aluno também vai exigir nome
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){
            //virtual significa que esse método pode ser sobrescrito por suas classes filhas
            Console.WriteLine($"Olá sou {Nome} de {Idade} anos");
        }
    }
}