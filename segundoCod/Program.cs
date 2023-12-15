using segundoCod.Models;

//Trabalhando com listas
List<string> listaString = new List<string>();
//Adicionando elementos
listaString.Add("SP");
listaString.Add("PE");
listaString.Add("BA");

//percorrendo a lista com o for
for(int contador = 0;contador<listaString.Count;contador++){
    Console.WriteLine($"posição {contador} - {listaString[contador]}");
}

//percorrendo a lista com o foreach
int contadorForEach = 0;
foreach(string item in listaString){
    Console.WriteLine($"posição {contadorForEach} - {item}");
    contadorForEach++;
}
//Explorando um pouco mais do que uma lista pode fazer
listaString.Add("MG");
Console.WriteLine($"capacidade - {listaString.Capacity}, items - {listaString.Count}");
listaString.Add("SC");
Console.WriteLine($"capacidade - {listaString.Capacity}, items - {listaString.Count}");
listaString.Remove("MG");
//o lugar de MG não vai ficar vazio como num array, outro item vai se realocar
Console.WriteLine($"capacidade - {listaString.Capacity}, items - {listaString.Count}");














// //declarando arrays
// int[] arrayInteiros = new int[3];

// arrayInteiros[0] = 43;
// arrayInteiros[1] = 32;
// arrayInteiros[2] = 56;
// //não pode acessar uma posição fora do array, dá bug

// //Mostrando arrays

// for(int contador = 0;contador<arrayInteiros.Length;contador++){
//     Console.WriteLine($"posição {contador}, valor {arrayInteiros[contador]}");
// }

// //percorrendo o array com o for each
// int contadorForEach = 0;
// foreach(int valor in arrayInteiros){
// //a variável valor vai receber o arrayInteiros em cada posição
//     Console.WriteLine($"posição {contadorForEach}, valor {valor}");
//     contadorForEach++;
// }
// //redimensionando um array com a classe Array com o metodo resize
// //um array nasce e morre do mesmo tamanho, o que o metodo resize faz é uma cópia com um novo tamanho
// Array.Resize(ref arrayInteiros,arrayInteiros.Length*2);
// //Array.Resize(referencia do array, novo tamanho)
// int contadorForEach2 = 0;
// foreach(int valor in arrayInteiros){
//     Console.WriteLine($"posição {contadorForEach2}, valor {valor}");
//     contadorForEach2++;
// }

























// ClasseMath calc = new ClasseMath();

// calc.Potencia(5, 2);
// calc.Seno(30);
// calc.Cosseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);

















// // Pessoa p = new Pessoa();
// // p.Nome = "peter";
// // p.Idade = 22;
// // p.Apresentar();


// // DateTime dataAtual = DateTime.Now;
// // Console.WriteLine(dataAtual);


// //convertendo tipos de variáveis
// int a = Convert.ToInt32("5");
// Console.WriteLine(a);
// int b = int.Parse("9");
// Console.WriteLine(b);
// //se colocar um não inteiro como parâmetro vai dar erro
// //pode ser usado com todas variáveis de string para int foi só um exemplo
// //A diferença entre o Convert e o Parse é que o Convert aceita null como parâmetro.

// //Conversão para string
// int inteiro = 5;
// string c = inteiro.ToString();
// Console.WriteLine(c); 

// //para converter de forma segura e não para o programa
// string exemplo = "tryparse";
// int.TryParse(exemplo, out int saida);
// Console.WriteLine(saida);