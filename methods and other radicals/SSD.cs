public class SSD: Harddrive{
    public SSD(string name, float cost, int capacity, int speed) : base(name, cost, capacity, speed){
        StorageType = "Flash Memory";
    }
}