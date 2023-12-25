using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public abstract class Conta
    {
        protected decimal saldo;
        //o tipo protected pode ser alterado pelas classes filhas
        public abstract void Creditar(decimal valor);
        //o método abstrato deve ser obrigatoriamente desenvolvido na classe filha
        public void ExibirSaldo(){
            System.Console.WriteLine($"Saldo de {saldo}");
        }
    }
}