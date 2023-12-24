using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public virtual void Apresentar(){
            //virtual significa que esse método pode ser sobrescrito por suas classes filhas
            Console.WriteLine($"Olá sou {Nome} de {Idade} anos");
        }
    }
}