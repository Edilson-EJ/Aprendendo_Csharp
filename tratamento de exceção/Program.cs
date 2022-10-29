
int[] numbrs = {1};
string s = null;

try{ // tratamento de erro Try catch
    Console.WriteLine(s.Length);
    Console.WriteLine(numbrs[2]);

}catch (System.NullReferenceException exception ){ //caso recebe alguma string nula vai se executado o cath
   // Console.WriteLine($"Erro de referencia nula.{exception.Message}"); // para mais info sobre o problema 
    Console.WriteLine($"Erro de referencia nula.{exception.StackTrace}"); // comando para identica a linha do erro

}catch(System.IndexOutOfRangeException exception){
    Console.WriteLine("Erro");
}