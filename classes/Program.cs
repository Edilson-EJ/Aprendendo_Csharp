
ILogger logger = new FileLogger("mylog.txt");

BackAccount account1 = new BackAccount("Edilson", 100,logger);

BackAccount account2 = new BackAccount("Isabela", 100,logger);

List<BackAccount> accounts = new List<BackAccount>(){
    account1,
    account2
}; // não entendi, pesquisa sobre

DataStore<int> store = new DataStore<int>();
    store.Value = 42;
    Console.WriteLine(store.Value);

account1.Deposit(-100);

account2.Deposit(100);

Console.WriteLine(account2.Balance);

List<int> numbers = new List<int>(){1,4,8,10}; // criando lista e iniciando a lista

foreach(int number in numbers){
    Console.WriteLine(number);
}

foreach(BackAccount account in accounts){
    Console.WriteLine(account.Balance);
}

class DataStore<T>{
    public T Value {get ; set; } 
}

class FileLogger : ILogger
{
    private readonly string filePath;

    public FileLogger(string filePath)
    {
        this.filePath = filePath;
    }
    public void Log(string message)
    {
        File.AppendAllText(filePath,$"{message}{Environment.NewLine}"); // metodo para criar um arquivo  com c#
    }
}

class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"LOGGER: {message}");
    }
}

interface ILogger{
    void Log(string message);
}

class BackAccount{
    string name; // já fica privado por padrão, mais vc pode coloca antes um public ou um private
    private readonly ILogger logger;

    public decimal Balance{ 
            get; private set;
    }

    public BackAccount(string name, decimal balance, ILogger logger){

        if(string.IsNullOrWhiteSpace(name)){ // vai verifica se a string e nula
            throw new Exception("Nome inválido");
        }
        if(balance < 0){
            throw new Exception("Saldo não pode ser negativo");
        }
        this.name = name;
        Balance = balance;
        this.logger = logger;
    }

    public void Deposit(decimal amount){
        if( amount > 0){
            Balance = Balance + amount;
        }else{
            logger.Log($"Não é possível depositr {amount} na conta de {name}");
        }
        
    }

    
}