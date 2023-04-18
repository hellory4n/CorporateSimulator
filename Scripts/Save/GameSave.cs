using System.Collections.Generic;

public class GameSave {
    public string Name = "Company Inc";
    public string Ceo = "Gill Bates";
    public string[] Industries = {"making money"};
    public long Money = 50000;
    public int Year = 1;
    public int Month = 1;
    public int Week = 1;
    public int Reputation = 75;
    public int ResearchPoints = 0;
    public int Investors = 1;
    public int WeeksWithoutPayingInvestors = 0;
    public int InvestorFrequency = 100;
    public int InvestorSusometer = 0;
    public List<EmployeeSave> Employees = new List<EmployeeSave>();
    public int Taxes = 1000;
    public List<ResearchSave> UnlockedResearch = new List<ResearchSave>();
    public List<ResearchSave> Researched = new List<ResearchSave>();
    public List<object> Products = new List<object>();
    public object Developing;
    public int DevelopingProgress = 0;
    public string DevelopingName = "PAIN XD";
    public int MarketingBudget = 0;
    public bool InvestorsInvested = false;
    public Stock[] Investments = new Stock[]{
        new Stock("silly co", 0, 0),
        new Stock("scamco", 0, 0),
        new Stock("cool oil", 0, 0),
        new Stock("bagged air", 0, 0),
        new Stock("robert tech", 0, 0),
        new Stock("deliciousness", 0, 0),
        new Stock("goggles", 0, 0),
        new Stock("macrohard", 0, 0),
        new Stock("databook", 0, 0),
        new Stock("pineapple", 0, 0),
        new Stock("amazing", 0, 0),
        new Stock("netfilms", 0, 0),
        new Stock("meloncars", 0, 0)
    };
    public Stock[] AvailableInvestments = new Stock[]{
        new Stock("silly co", 0, 420),
        new Stock("scamco", 0, 420),
        new Stock("cool oil", 0, 420),
        new Stock("bagged air", 0, 420),
        new Stock("robert tech", 0, 420),
        new Stock("deliciousness", 0, 420),
        new Stock("goggles", 0, 420),
        new Stock("macrohard", 0, 420),
        new Stock("databook", 0, 420),
        new Stock("pineapple", 0, 420),
        new Stock("amazing", 0, 420),
        new Stock("netfilms", 0, 420),
        new Stock("meloncars", 0, 420)
    };
    public string Version = "0.9";
    public StoreItem[] Purchased = new StoreItem[]{
        new StoreItem("Bagged Air"),
        new StoreItem("Squaritos"),
        new StoreItem("Washing Machine"),
        new StoreItem("Remote-controlled Grill"),
        new StoreItem("A Thing"),
        new StoreItem("hiPhone 15"),
        new StoreItem("Innovative T-Shirt"),
        new StoreItem("hiToothbrush"),
        new StoreItem("ELECTRIC GRID KILLER 6900"),
        new StoreItem("Bagged Air Barbecue"),
        new StoreItem("Bagged Air Cheese"),
        new StoreItem("hiPhone 16"),
        new StoreItem("Webdoor"),
        new StoreItem("Flying House"),
        new StoreItem("WebToasts"),
        new StoreItem("Milk"),
        new StoreItem("hiPhone 17"),
        new StoreItem("Bag with rocks"),
        new StoreItem("Bagged Air Air"),
        new StoreItem("webtoasts²"),
        new StoreItem("hiPhone 18"),
        new StoreItem("Remote controller for a horse"),
        new StoreItem("Cheese"),
        new StoreItem("Bagged Air Fart"),
        new StoreItem("Bagged Air Spicy"),
        new StoreItem("hiPhone 19"),
        new StoreItem("Orange Juice"),
        new StoreItem("webtoasts³"),
        new StoreItem("Random number book"),
        new StoreItem("Choccy milk"),
        new StoreItem("hiPhone 20"),
        new StoreItem("webtoasts⁴"),
        new StoreItem("Skepticism Antivirus"),
        new StoreItem("Cookie"),
        new StoreItem("Money"),
        new StoreItem("Air without a bag"),
        new StoreItem("hiPhone 21"),
        new StoreItem("webpaper"),
        new StoreItem("Wireless Charger"),
        new StoreItem("Bag surrounded by air in a bag"),
        new StoreItem("hiPhone 22"),
        new StoreItem("webpaper²"),
        new StoreItem("Toilet Paper"),
        new StoreItem("A lot of money"),
        new StoreItem("Holy Cheese"),
        new StoreItem("hiPhone 23"),
        new StoreItem("Smiling rock"),
        new StoreItem("Infinite potatos"),
        new StoreItem("Golden tophat"),
        new StoreItem("Bagged Air Onion"),
    };
}