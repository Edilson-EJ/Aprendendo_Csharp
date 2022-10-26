int idade;

Console.WriteLine("Digite sua idade");

idade = int.Parse(Console.ReadLine());

if(idade < 18){
    Console.WriteLine("Menor de idade");

}else{
    Console.WriteLine("Maior de idade");
}