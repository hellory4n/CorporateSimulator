public class Product {
    public string Name;
    public int Rating;
    public int Sales;
    public int MoneySpent;
    public int MoneyGot;
    public string Type;
}

public class SpaceProduct : Product {
    public int RocketBoost;
    public string Carrying;
    public int? People;
    public string Destination;
}