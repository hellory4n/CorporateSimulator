using Godot;
using System;
using Newtonsoft.Json;

class Savior {
    public static SettingsSave CreateFileStuff() {
        // ben
        File settingsFile = new File();
        SettingsSave settings = new SettingsSave();

        #region settings.json
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
        #endregion

        return settings;
    }



    public static void SaveSettings(SettingsSave settings) {
        File file = new File();
        file.Open("user://settings.json", File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(settings)
        );
    }
}