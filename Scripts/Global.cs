using Godot;
using System;
using System.Collections.Generic;

public class Global : Node2D {
    public static long Money = 694201337;
    public static int Year = 1;
    public static int Month = 1;
    public static int Week = 1;
    public static bool PausedTime = false;
    public static float WeekCounterThing = 0;
    public static int Reputation = 100;
    public static SettingsSave Settings = new SettingsSave();
    public static string SaveFile;
    // signals decided to not work
    public static int NewCompanyDialogIndustryIndex;
    public static GameSave NewGameSave;
    public static string CompanyName;
    public static string CeoName;
    public static string[] Industries;
    public static bool SavesMenuFromNewGame;
    public static int ResearchPoints;
    public static int Investors;
    public static int WeeksWithoutPayingInvestors;
    public static int InvestorsWant;
    public static int InvestorFrequency;
    public static float InvestorTimeCounterThing;
    public static int InvestorPayment;
    public static int InvestorSusometer;
    public static float InvestorSusometerCounterThingyUhh;
    public static List<EmployeeSave> Employees;
    public static int Garbage1;
    public static int Garbage2;
    public static int Taxes;
    public static int Salaries;
    public static List<ResearchSave> UnlockedResearch;
    public static List<ResearchSave> Researched;
    public static SpaceProduct SpaceNewProduct = new SpaceProduct();
    public static List<object> Products = new List<object>();
    public static object Developing;
    public static int DevelopingProgress;
    public static string DevelopingName;
    public static BookProduct BookNewProduct = new BookProduct();
    public static MedicalProduct MedicalNewProduct = new MedicalProduct();
    public static ComputerProduct ComputerNewProduct = new ComputerProduct();
    public static MusicProduct MusicNewProduct = new MusicProduct();
    public static MediaProduct MediaNewProduct = new MediaProduct();
    public static FoodProduct FoodNewProduct = new FoodProduct();
    public static TvProduct TvNewProduct = new TvProduct();
    public static ElectronicsProduct ElectronicsNewProduct = new ElectronicsProduct();
    public static AppProduct AppNewProduct = new AppProduct();
}