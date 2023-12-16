using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerceiroCod.Models
{
    public class Curso
    {
        //o construtor não muda nada do que vi em java
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno){
            Alunos.Add(aluno);
        }
        public int ObterQuantidadeDeAlunosMatriculados(){
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno){
            return Alunos.Remove(aluno);
        }

        public void ListarAlunos(){
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            }
        }
    }
}