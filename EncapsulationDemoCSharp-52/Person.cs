namespace EncapsulationDemoCSharp_52;

public class Person
{
    //Properties
    public string Name { get; set; }
    public int Age { get; set; }
    
    //Fields
    private double _wallet;
    
    //Methods (public) can access the private field
    public void AddMoney(double amount)
    {
        _wallet += amount;
    }

    public double GetWallet()
    {
        return _wallet;
    }
}