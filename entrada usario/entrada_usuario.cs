
int valor1;
int valor2;


Console.WriteLine("Digite o primeiro valor?");
valor1 = int.Parse(Console.ReadLine()); //captura informação do usuario e usando o int.Parse transforma em inteiro

Console.WriteLine("Digite o primeiro valor 2?");
valor2 = int.Parse(Console.ReadLine()); 

int soma = valor1 + valor2;

Console.WriteLine("O valor da soma e:" + soma);