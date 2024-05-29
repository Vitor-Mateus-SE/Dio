using Examplefundamentals.Common.Models;
using ExemploFundamentos.Common.models;

/*Calculadora calc = new Calculadora();
calc.Raiz(25);
Console.WriteLine(calc);

int numero = 5;
for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");

}
string opcao;
while (true)
{
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("opção invalida");
            break;
    }
}*/
int[] arrayInterios = new int[3];
arrayInterios[0] = 72;
arrayInterios[1] = 64;
arrayInterios[2] = 50;

for (int contador = 0; contador < arrayInterios.Length; contador++)
{
    Console.WriteLine($"Posição número {contador} - {arrayInteiros[contador]}");
}