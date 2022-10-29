int ano_atual = 2022;

Console.WriteLine("Digite o ano que você nasceu");
int ano_nasci = int.Parse(Console.ReadLine());

int idade = ano_atual - ano_nasci;

if( idade < 18){
    Console.WriteLine("Menor de idade! " + idade);
} else{
    Console.WriteLine("Maior de idade! " + idade);
}
