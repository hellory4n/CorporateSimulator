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
        save.Money = Global.Money;
        save.Year = Global.Year;
        save.Month = Global.Month;
        save.Week = Global.Week;
        save.Reputation = Global.Reputation;
        save.Name = Global.CompanyName;
        save.Ceo = Global.CeoName;
        save.Industries = Global.Industries;
        save.ResearchPoints = Global.ResearchPoints;
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
        // TODO: make it open the new game dialog when the save doesn't exist
        file.Open(saveFile, File.ModeFlags.Read);
        GameSave obama = JsonConvert.DeserializeObject<GameSave>(
            file.GetAsText()
        );
        file.Close();
        return obama;
    }
}