using TerceiroCod.Models;
using System.Globalization;

//Execções genéricas e especificas

try{
     string [] linhas = File.ReadAllLines("Arquivos/d/arquivo_01.txt");
    foreach(string linha in linhas){
         Console.WriteLine(linha);
     }
}catch(FileNotFoundException ex){
    Console.WriteLine($"Ocorreu uma exceção específica de arquivo: {ex.Message}");
}
catch(DirectoryNotFoundException ex){
    Console.WriteLine($"Ocorreu uma exceção específica de diretório: {ex.Message}");
}

catch(Exception ex){//genérica
     Console.WriteLine($"Ocorreu uma exceção genérica: {ex.Message}");
} 
finally{
    Console.WriteLine("Programa executado");
}
//o bloco finally é executado independente de ter exceções











//Exceções
// try{
//     string [] linhas = File.ReadAllLines("Arquivos/arquivo_01.txt");
//     foreach(string linha in linhas){
//         Console.WriteLine(linha);
//     }
// }catch(Exception ex){
//     Console.WriteLine($"Ocorreu uma exceção: {ex.Message}");
// }
// // try - ele vai tentar executar o código
// // catch(Exception ex) - sizeof tiver uma exceção ele vai armazená-la na variavel ex
// // obs - sem o tratamento de exceções ele não vai executar nada depois que parar na exceção
// Console.WriteLine("Com o tratamento ele executa o que vem depois da exceção");











// //formatando valores monetários
// decimal valorMonetario = 1523.32M;

// Console.WriteLine($"{valorMonetario:c}");
// //:c é para formatar em formato de currency(moeda),
// // e ele retorna em reais porque as cofigurações do meu sistema está para o local que estou
// //para alterar segue abaixo o exemplo lembrando de colocar o using System.Globalization; no inicio
// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
// //para mais formatação de dados ver documentação













//     Pessoa p1 = new Pessoa();
//     p1.Nome = "Peter";
//     p1.Idade = 22;
//     p1.Sobrenome = "Barbos";
//     p1.Apresentar();

//     Pessoa p2 = new Pessoa();
//     p2.Nome = "Jota";
//     p2.Sobrenome = "Carlos";

//     Curso ingles = new Curso();
//     ingles.Nome = "Inglês";
//     //tem que adicionar a lista aqi novamente
//     ingles.Alunos = new List<Pessoa>();
//     ingles.AdicionarAluno(p1);
//     ingles.AdicionarAluno(p2);
//     ingles.ListarAlunos();
