string[] names = {"edilson", "melo",".net"};

string[] idades = {"23","45", "60"};

for (int i = 0; i < names.Length; i++){
    Console.WriteLine(names[i]);
}

foreach (string idade in idades){
    Console.WriteLine(idade);
}