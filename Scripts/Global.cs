using Godot;
using System;

public class Global : Node2D {
    public static int Money = 694201337;
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
}
