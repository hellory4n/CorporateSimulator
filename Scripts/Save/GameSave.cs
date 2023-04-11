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
    public string Version = "0.8";
    public int StockMonths = 1;
}