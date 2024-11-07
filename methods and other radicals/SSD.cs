public class SSD: Harddrive{
    public SSD(string name, float cost, int capacity, int speed) : base(name, cost, capacity, speed){
        Type = Type + " - Solid State Drive";
        StorageType = "Flash Memory";
    }
}