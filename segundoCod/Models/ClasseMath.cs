using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace segundoCod.Models
{
    public class ClasseMath
    {
        //Potenciação
        public void Potencia(double x, double y){
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x}^{y} = {pot}");
        }
        //funções trigonométricas
        public void Seno(double angulo){
            //Primeiro tem que transformar para radianos
            double radiano = angulo * Math.PI/180;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} é {seno}");
        }
         public void Cosseno(double angulo){
            //Primeiro tem que transformar para radianos
            double radiano = angulo * Math.PI/180;
            double cosseno = Math.Cos(radiano);
            Console.WriteLine($"Cosseno de {angulo} é {cosseno}");
        }
         public void Tangente(double angulo){
            //Primeiro tem que transformar para radianos
            double radiano = angulo * Math.PI/180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} é {Math.Round(tangente,4)}");
            //round é para arrendondar para (número, qt de dígitos)
        }

        //Raiz quadrada
        public void RaizQuadrada(double x){
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz de {x} é {raiz}");
        }
    }
}