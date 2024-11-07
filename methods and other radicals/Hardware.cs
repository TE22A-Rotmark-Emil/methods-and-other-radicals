public class Hardware{
    string name;
    float price;
    protected string type = "undefined";

    public Hardware(string item, float cost){
        name = item;
        price = cost;
    }

    public string GetName(){
        return name;
    }

    public float GetPrice(){
        return price;
    }
}