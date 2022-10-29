
BackAccount account1 = new BackAccount("Edilson", 100);

BackAccount account2 = new BackAccount("Isabela", 100);

account1.Deposit(-100);
account2.Deposit(100);

Console.WriteLine(account2.Balance);

class BackAccount{
    string name; // já fica privado por padrão, mais vc pode coloca antes um public ou um private
    private decimal balance;

    public decimal BackAccount{ 
        get {return balance; } 
        set {balance = value; }
    }

    public BackAccount(string name, decimal balance){

        if(string.IsNullOrWhiteSpace(name)){ // vai verifica se a string e nula
            throw new Exception("Nome inválido");
        }
        if(balance < 0){
            throw new Exception("Saldo não pode ser negativo");
        }
        this.name = name;
        this.balance = balance;
    }

    public void Deposit(decimal amount){
        if( amount > 0){
            balance = balance + amount;
        }else{
            throw new Exception("Valor Inválido");
        }
        
    }

    
}