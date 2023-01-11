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

public class MedicalProduct : Product {
    public int Accuracy = 69;
    public int Marketing = 69;
}

public class ComputerProduct : Product {
    public string Cpu = "None,None,0,0";
    public string Gpu = "None,None,0,0";
    public string Ram = "0,0,0";
    public string Storage = "None,0,0,0";
    public string Os = "None,None,0,0";
    public int Price = 0;
}

public class MusicProduct: Product {
    public int Speed = 50;
    public int Melody = 0;
    public int Instruments = 69;
}

public class MediaProduct : Product {
    public string Theme = "Intense Farding";
    public string Genre = "True Crime";
    public decimal ThemeGenreCombination = 0;
    public int Lore = 69;
    public int Storytelling = 69;
    public int Characters = 69;
}

public class FoodProduct : Product {
    public int NutritionalValue = 0;
    public int Taste = 100;
}

public class TvProduct: Product {
    public string TvType = "fake news";
    public int ProductionTime = 69;
    public int Script = 69;
    public int Ads = 100;
}

public class ElectronicsProduct : Product {
    public int Features = 69;
    public int Security = 69;
    public int IoTNess = 69;
}

public class AppProduct : Product {
    public string AppType = "chinese tracking software";
    public int Algorithm = 100;
    public int Features = 50;
    public int Innovation = 0;
}