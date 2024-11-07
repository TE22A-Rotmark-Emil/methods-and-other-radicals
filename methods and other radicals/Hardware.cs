public class Hardware{
    protected string Name;
    float Price;
    protected string Type = "undefined";

    public Hardware(string item, float cost){
        Name = item;
        Price = cost;
    }

    public string GetName(){
        return Name;
    }

    public float GetPrice(){
        return Price;
    }

    public virtual void ListSpecs(){
        Console.WriteLine($"Cost: {Price}$");
        Console.WriteLine($"Type: {Type}");
    }
}