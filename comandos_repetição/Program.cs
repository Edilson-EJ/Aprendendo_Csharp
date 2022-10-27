Boolean condicao = true;

int valor =5;
int i = 0;

while(valor >= i){
    Console.WriteLine("while!!" + i);
    i++;
}

i = 0;
do{
    Console.WriteLine(" do while!!" + i);
    i++;
}while(valor >= i);

for( int j = 0; valor >= j; j++){
    Console.WriteLine("for: " + j);
}

int[] lista = {1,2,3,4,5};

foreach(int numero in lista){
    Console.WriteLine("ForEach: " + numero);
}