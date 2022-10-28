using Godot;
using System;
using Newtonsoft.Json;

class Savior {
    public static SettingsJson CreateFileStuff() {
        // ben
        File settingsJson = new File();
        SettingsJson settings = new SettingsJson();

        if (!settingsJson.FileExists("user://settings.json")) {
            settingsJson.Open("user://settings.json", File.ModeFlags.Write);
            settingsJson.StoreString(
                JsonConvert.SerializeObject(settings)
            );
        } else {
            settingsJson.Open("user://settings.json", File.ModeFlags.Read);
            settings = JsonConvert.DeserializeObject<SettingsJson>(
                settingsJson.GetAsText()
            );
        }

        return settings;
    }



    public static void SaveSettings(SettingsJson settings) {
        File file = new File();
        file.Open("user://settings.json", File.ModeFlags.Write);
        file.StoreString(
            JsonConvert.SerializeObject(settings)
        );
    }
}