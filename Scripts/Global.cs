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
}
