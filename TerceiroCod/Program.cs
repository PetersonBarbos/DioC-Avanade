using TerceiroCod.Models;
using System.Globalization;

//formatando valores monetários
decimal valorMonetario = 1523.32M;

Console.WriteLine($"{valorMonetario:c}");
//:c é para formatar em formato de currency(moeda),
// e ele retorna em reais porque as cofigurações do meu sistema está para o local que estou
//para alterar segue abaixo o exemplo lembrando de colocar o using System.Globalization; no inicio
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
//para mais formatação de dados ver documentação













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
