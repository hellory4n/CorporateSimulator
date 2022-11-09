using System.Collections.Generic;

public class GameSave {
    public string Name = "Company Inc";
    public string Ceo = "Gill Bates";
    public string[] Industries = {"making money"};
    public int Money = 50000;
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
}