using Godot;
using System;
using Newtonsoft.Json;

class Savior {
    public static SettingsSave CreateFileStuff() {
        // ben
        File settingsFile = new File();
        SettingsSave settings = new SettingsSave();

        if (!settingsFile.FileExists("user://settings.json")) {
            settingsFile.Open("user://settings.json", File.ModeFlags.Write);
            settingsFile.StoreString(
                JsonConvert.SerializeObject(settings)
            );
            settingsFile.Close();
        } else {
            settingsFile.Open("user://settings.json", File.ModeFlags.Read);
            settings = JsonConvert.DeserializeObject<SettingsSave>(
                settingsFile.GetAsText()
            );
            settingsFile.Close();
        }

        return settings;
    }

    public static void SaveSettings(SettingsSave settings) {
        File file = new File();
        file.Open("user://settings.json", File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(settings)
        );
    }

    public static void SaveGame(string saveFile) {
        File file = new File(); // is this a file?
        GameSave save = new GameSave();
        // TODO: save more things
        #region uhh
        save.Money = Global.Money;
        save.Year = Global.Year;
        save.Month = Global.Month;
        save.Week = Global.Week;
        save.Reputation = Global.Reputation;
        save.Name = Global.CompanyName;
        save.Ceo = Global.CeoName;
        save.Industries = Global.Industries;
        save.ResearchPoints = Global.ResearchPoints;
        save.Investors = Global.Investors;
        save.WeeksWithoutPayingInvestors = Global.WeeksWithoutPayingInvestors;
        save.InvestorFrequency = Global.InvestorFrequency;
        save.InvestorSusometer = Global.InvestorSusometer;
        save.Employees = Global.Employees;
        save.Taxes = Global.Taxes;
        save.UnlockedResearch = Global.UnlockedResearch;
        save.Researched = Global.Researched;
        save.Products = Global.Products;
        save.Developing = Global.Developing;
        save.DevelopingProgress = Global.DevelopingProgress;
        save.DevelopingName = Global.DevelopingName;
        save.MarketingBudget = Global.MarketingBudget;
        save.InvestorsInvested = Global.InvestorsInvested;
        save.Investments = Global.Investments;
        save.AvailableInvestments = Global.AvailableInvestments;
        save.Version = Global.Version;
        save.Purchased = Global.Purchased;
        save.Advisor = Global.Advisor;
        save.MoneyHistory = Global.MoneyHistory;
        save.LabUnlocked = Global.LabUnlocked;
        save.LabResearch = Global.LabResearch;
        save.LabBudget = Global.LabBudget;
        save.LabThingsToSpend = Global.LabThingsToSpend;
        save.LabCurrentProject = Global.LabCurrentProject;
        save.LabTotalCost = Global.LabTotalCost;
        save.CustomOS = Global.CustomOS;
        save.CustomChip = Global.CustomChip;
        save.CustomConsole = Global.CustomConsole;
        save.GovernmentUnlocked = Global.GovernmentUnlocked;
        save.CountryName = Global.CountryName;
        save.UnitedStates = Global.UnitedStates;
        save.China = Global.China;
        save.Army = Global.Army;
        save.Navy = Global.Navy;
        save.AirForce = Global.AirForce;
        save.Invaded = Global.Invaded;
        #endregion
        file.Open(saveFile, File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(save)
        );
        file.Close();
        GD.Print("game successfully saved");
    }

    public static void NewGame(string saveFile, GameSave save) {
        File file = new File();
        file.Open(saveFile, File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(save)
        );
        file.Close();
    }

    public static GameSave LoadGame(string saveFile) {
        File file = new File(); // directory
        file.Open(saveFile, File.ModeFlags.Read);
        GameSave obama = JsonConvert.DeserializeObject<GameSave>(
            file.GetAsText()
        );
        file.Close();
        return obama;
    }

    public static AchievementSave CreateAchievements() {
        // ben
        File file = new File();
        AchievementSave achievements = new AchievementSave();

        if (!file.FileExists("user://achievements.json")) {
            file.Open("user://achievements.json", File.ModeFlags.Write);
            file.StoreString(
                JsonConvert.SerializeObject(achievements)
            );
            file.Close();
        } else {
            file.Open("user://achievements.json", File.ModeFlags.Read);
            achievements = JsonConvert.DeserializeObject<AchievementSave>(
                file.GetAsText()
            );
            file.Close();
        }

        return achievements;
    }

    public static void SaveAchievements(AchievementSave achievements) {
        File file = new File();
        file.Open("user://achievements.json", File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(achievements)
        );
    }
}