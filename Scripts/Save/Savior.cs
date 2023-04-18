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
}