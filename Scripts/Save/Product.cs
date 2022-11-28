public class Product {
    public string Name = "ben";
    public int Rating = 0;
    public int Sales = 0;
    public int MoneySpent = 0;
    public int MoneyGot = 0;
    public string Type = "product";
}

public class SpaceProduct : Product {
    public int RocketBoost = 0;
    public string Carrying = "Nothing";
    public int People = 0;
    public string Destination = "Earth's orbit";
    public int Speed = 0;
    public int Fuel = 0;
    public int Safety = 0;
}

public class BookProduct : Product {
    public string Theme = "Cookbook";
    public string Genre = "War";
    public decimal ThemeGenreCombination = 0;
    public int Lore = 69;
    public int Storytelling = 69;
    public int Characters = 69;
}