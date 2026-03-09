public class Instrument
{
    public int ID { get; set; };
    public string Name { get; set; };
    public string Brand { get; set; };
    public Instrument_Category Category { get; set; };
    public double Price { get; set; };
    public string Description { get; set; };
    public int Quantity { get; set; };
    public double Discount { get; set; };
    public double Final_Price()
    {
        return Price - (Price - Discount / 100);
    }
}
public class Client
{

    public int ID { get; set; };
    public string Name { get; set; };
    public string Email { get; set; };
    public string Password { get; set; };
}
public class Account_Clients
{
    public void Create_Account()
    {

    }
}
public enum Instrument_Category
{
    Guitars,
    Drums,
    Keyboards,
    Mics,
    Amps,
    Synths,
    Cables,
    Strings,
    Accessories
}
class Store
{
    public void Add_Instrument(Instrument instrument)
    {

    }
    public void Delete_Instrument()
    {

    }
    public void Update_Instrument(Instrument instrument)
    { 

    }
    public Instrument Search_Instrument(string name)
    {

    }

}

class Program
{
    static void Main()
    {

    }

}