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
    public static PhoneProduct PhoneNewProduct = new PhoneProduct();
    public static YourArseProduct YourArseNewProduct = new YourArseProduct();
    public static int MarketingBudget = 0;
    public static int MonthlySales = 0;
    /*0 = fine
    1 = ono dialog
    2 = ono dialog already appeared*/
    public static int DebtOno = 0;
    public static bool PoliticsAlreadyAppeared = false;
    public static bool ClimateChange = false;
    public static bool Ac = false;
    public static bool LowReputationScam = false;
    public static bool UnlockMarketing1 = false;
    public static bool ViralThingy = false;
    public static bool NoEntiendoScam = false;
    public static bool UnlockMarketing2 = false;
    public static bool Lottery = false;
    public static bool SpacezSatellites = false;
    public static bool SpaceZLunarPissProject1 = false;
    public static bool NoseLunarPissProject1 = false;
    public static bool NoseLunarPissProject2 = false;
    public static bool SpacezPissOnTheMoon = false;
    public static bool NosePissOnTheMoon = false;
    public static bool EpicGalaxiesHotel = false;
    public static bool SpacezMarsLanding = false;
    public static bool NoseMarsLanding = false;
    public static bool EarthOrbitTrash = false;
    public static bool EarthOrbitTrash2 = false;
    public static bool UnlockSpaceColonization = false;
    public static bool SpacezColonization = false;
    public static bool NoseColonization = false;
    public static bool YourMom1 = false;
    public static bool BookMovie = true;
    public static bool YourMom2 = false;
    public static bool YourMom3 = false;
    public static bool YourMom4 = false;
    public static bool YourMom5 = false;
    public static bool YourMom6 = false;
    public static bool BadMedicalThing = true;
    public static bool TheCureForCancer = false;
    public static bool ReverseDisease = false;
    public static bool Taxes1 = false;
    public static bool Taxes2 = false;
    public static bool Lab = false;
    public static bool Ecs1 = false;
    public static bool Ecs2 = false;
    public static bool Ecs3 = false;
    public static bool Ecs4 = false;
    public static bool Ecs5 = false;
    public static bool Ecs6 = false;
    public static bool Ecs7 = false;
    public static bool Ecs8 = false;
    public static bool Ecs9 = false;
    public static bool Ecs10 = false;
    public static bool PrinceInEngland = false;
    public static bool InfiniteCoffeeMachine = false;
    public static bool InfiniteTeaMachine = false;
    public static bool JamesPhotos = false;
    public static bool WhiteRoom = false;
    public static bool FloatingOffice = false;
    public static bool FartSmells = false;
    public static bool OfficeInsideOffice = false;
    public static bool MoneyPrinter = false;
    public static bool MoveToPaintopia = false;
    public static bool Interview = false;
    public static bool Offended = true;
    public static bool _4DMusic = false;
    public static bool InterdimensionalMusic = false;
    public static bool UniverseBreakingMusic = false;
    public static bool MusicThatMakesNewMultiverses = false;
    public static bool NoisesII = false;
    public static bool MessagingAppDisease = true;
    public static bool ApplianceSecurityBreach = true;
    public static bool Boom = true;
    public static bool EcsPhone1 = false;
    public static bool EcsPhone2 = false;
}