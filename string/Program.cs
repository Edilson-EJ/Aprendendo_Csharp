
string name = "edilson";

string sobrenome =" ";

string[] cidade = {"jaguaribe", "são miguel"};

Console.WriteLine(name.Length); //verifica quantos caracteres
Console.WriteLine(name.EndsWith("son")); // verifica se no final da string tem caracteres espeficos pode ser 1 ou mais
Console.WriteLine(name.EndsWith("n"));

Console.WriteLine(name.StartsWith("e")); // verifica o começo da string

Console.WriteLine(name.Contains("e")); // verifica ser tem um caratere espefico na string

Console.WriteLine(name.IndexOf("d")); // verifca em qual posição esta a string

Console.WriteLine(string.IsNullOrEmpty(sobrenome)); //verifca ser a string esta vazia, não detecta espaço 

Console.WriteLine(string.IsNullOrWhiteSpace(sobrenome)); // caso tenha um espaço na string ele detecta

Console.WriteLine(string.Join(':', cidade)); // esse metodo junta as strings do array e dentro das aspas vc pode passa + ou : ou outro caractere para concatena



