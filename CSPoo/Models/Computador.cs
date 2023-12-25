using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSPoo.Models
{
    public class Computador:Object
    //A classe System.Objec é a mãe de todas as classe na hierarquia do .NET
    //A classe Object temm como objetivo fornecer serviços de baixo nível para suas filhas
    {
        public override string ToString(){
            return "Método ToString sobrescrito";
        }
    }
}