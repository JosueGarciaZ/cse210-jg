namespace Costume;

class Costume
{
    //attributes
    public string _headwear;
    public string _upperGarment;
    public string _lowerGarment;
    public string _footwear;
    public string _accesories;
    //behavior
    public void Output()
    {
        Console.WriteLine("Costume pieces:");
        Console.WriteLine($"head: {_headwear}");
        Console.WriteLine($"torso: {_upperGarment}");
        Console.WriteLine($"legds: {_lowerGarment}");
        Console.WriteLine($"Feet: {_footwear}");
        Console.WriteLine($"other: {_accesories}");
    }
}