
interface Ilogger{
    void Log(string message);
}

class ConsoleLogger: Ilogger{
    public void Log(string message){
        Console.WriteLine("Error");        
    }
}
