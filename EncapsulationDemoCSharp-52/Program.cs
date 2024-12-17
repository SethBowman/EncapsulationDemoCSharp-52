namespace EncapsulationDemoCSharp_52;

class Program
{
    static void Main(string[] args)
    {
        var seth = new Person();
        
        var currentWallet = seth.GetWallet();

        Console.WriteLine(currentWallet);
        
        seth.AddMoney(500.00);
        
        currentWallet = seth.GetWallet();

        Console.WriteLine(currentWallet);
    }
}