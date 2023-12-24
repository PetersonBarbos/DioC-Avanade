using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(decimal valor){
            if(saldo>= valor){
            saldo -= valor;
            System.Console.WriteLine("Saque realizado com sucesso");
            } else{
                System.Console.WriteLine("Valor desejado é maior que o saldo");
            }
        }
        public void ExibirSaldo(){
            System.Console.WriteLine($"Seu saldo disponível é {saldo}");
        }
    }
}