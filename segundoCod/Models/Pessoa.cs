using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace segundoCod.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"olá, meu nome é {Nome} e eu tenho {Idade} anos");
        }
    }
}