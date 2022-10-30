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
        save.Money = Global.Money;
        save.Year = Global.Year;
        save.Month = Global.Month;
        save.Week = Global.Week;
        save.Reputation = Global.Reputation;
        file.Open(saveFile, File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(save)
        );
        file.Close();
        GD.Print("game successfully saved");
    }
}