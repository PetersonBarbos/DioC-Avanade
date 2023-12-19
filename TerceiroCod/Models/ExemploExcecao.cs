using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerceiroCod.Models
{
    public class ExemploExcecao
    {
        // public void Metodo1(){
        //     Metodo2();
        // }
        public void Metodo1(){
            try{
            Metodo2();
            }catch (Exception){
            Console.WriteLine("Exceção captada");
            }
        }
        public void Metodo2(){
            Metodo3();
        }
        public void Metodo3(){
            Metodo4();
        }
        public void Metodo4(){
            throw new Exception("Ocorreu uma exceção");
            //Quando chegar aqui o throw vai jogar o código pelo caminho de volta até achar um tratamento para a exceção
            //caso não encontre ele vai exibir aquela mensagem de exceção grande o StackTrace
        }
    }
}