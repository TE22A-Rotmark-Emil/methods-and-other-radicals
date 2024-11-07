public class HDD: Harddrive{
    public HDD(string name, float cost, int capacity, int speed) : base(name, cost, capacity, speed){
        Type = Type + " - Hard Disk Drive";
        StorageType = "Magnetic Disk";
    }
}