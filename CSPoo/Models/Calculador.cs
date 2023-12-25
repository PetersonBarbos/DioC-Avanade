using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSPoo.Interfaces;
//using pasta da interface

namespace CSPoo.Models
{
    public class Calculador:ICalculadora
    {
       
        public int Subtrair(int num1, int num2){
            return num1-num2;
        }
        public int Multiplicar(int num1, int num2){
            return num1*num2;
        }
        public int Dividir(int num1, int num2){
            return num1/num2;
        }
    }
}