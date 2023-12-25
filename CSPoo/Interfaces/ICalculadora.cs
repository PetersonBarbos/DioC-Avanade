using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2){
        //se eu desenvolver um método aqui, vai se tornar opcional o desenvolvimento dele na classe
            return num1+num2;
        }
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}