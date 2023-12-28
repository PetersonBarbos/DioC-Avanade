using Calculadora.services;

/*criei uma pasta e dentro dessa pasta criei mais duas pastas, uma para testes e 
outra para o programa em si , na do console crio um programa dotnet normal e na do teste
crio um dotnet new xunit.
obs: com extensão solutions crio um novo solution e adiciono o teste e o programa no solution
e faz o teste referenciar o programa.
aí na na pasta do programa cria uma pasta servicer e desenvolve o código*/
Calculadoraimp c = new Calculadoraimp();
int num1 = 5;
int num2 = 7;
Console.WriteLine($"{num1} + {num2} = {c.Somar(num1, num2)}");