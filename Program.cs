global using System; 

class Program {
    static void Main(){

        Funcionalidades.Funcoes funcionalidades = new Funcionalidades.Funcoes();

        Console.WriteLine("\nInforme seu saldo Bancario: "); 
        funcionalidades.setSaldoBancario(Convert.ToInt64(Console.ReadLine()));

        funcionalidades.sacarDinheiro();
    }
}