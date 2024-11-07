using System.Reflection.Metadata.Ecma335;

public class Harddrive: Hardware{
    int Storage;
    int Speed;
    protected string StorageType = "undefined";

    public Harddrive(string item, float cost, int capacity, int speed) : base(item, cost){
        Name = FunkyNameRandomiser(Name);
        Storage = capacity;
        Speed = speed;
        Type = "Harddrive";
    }

    public int GetStorage(){
        return Storage;
    }

    public int GetSpeed(){
        return Speed;
    }

    public override void ListSpecs()
    {
        Console.WriteLine($"Item: {Name}");
        base.ListSpecs();
        Console.WriteLine($"Storage: {Storage}GB");
        Console.WriteLine($"Speed: {Speed}MHz");
        Console.WriteLine($"Type: {StorageType}");
    }

    string FunkyNameRandomiser(string name){
        char[] Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        int RandomIntegerIdentity = Random.Shared.Next(1111, 9999) + 1;
        string RandomIdentifier = RandomIntegerIdentity.ToString();
        int RandomLocationForRandomLetter = Random.Shared.Next(RandomIdentifier.Count());
        string RandomIdentifierReal = "";

        Console.WriteLine(RandomLocationForRandomLetter);

        for (int i = 0; i < RandomIdentifier.Length; i++)
        {
            if (i == RandomLocationForRandomLetter && i != 0){
                RandomIdentifierReal += Alphabet[Random.Shared.Next(Alphabet.Count())];
            }
            RandomIdentifierReal += RandomIdentifier[i].ToString();
            if (i == RandomLocationForRandomLetter && i == 0){
                RandomIdentifierReal += Alphabet[Random.Shared.Next(Alphabet.Count())];
            }
        }
        return RandomIdentifierReal;
    }
}