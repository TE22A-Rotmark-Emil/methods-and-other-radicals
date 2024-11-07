public class Harddrive: Hardware{
    int Storage;
    int MHz;
    protected string StorageType = "undefined";

    public Harddrive(string item, float cost, int capacity, int speed) : base(item, cost){
        Storage = capacity;
        MHz = speed;
        type = "Harddrive";
    }

    public int GetStorage(){
        return Storage;
    }

    public int GetSpeed(){
        return MHz;
    }
}