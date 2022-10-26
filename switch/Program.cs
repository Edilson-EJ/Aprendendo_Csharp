
int mes;

Console.WriteLine("Digite um mês");

mes = int.Parse(Console.ReadLine());

switch(mes){

    case 1:
        Console.WriteLine("Janeiro");
        break;
    case 2:
        Console.WriteLine("fevereiro");
        break;
    case 3:
        Console.WriteLine("Março");
        break;
    default:
        Console.WriteLine("ops!!");
        break;
    

}