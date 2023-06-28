using System;
using System.Collections.Generic;
using Godot;

public class Modding {
    public static void LoadMods() {
        Directory modfolder = new Directory();
        List<string> mods = new List<string>();
        if (modfolder.DirExists("user://mods")) {
            GD.Print("mods exist");
            modfolder.Open("user://mods/");

            // find what mods exist
            modfolder.ListDirBegin(true);
            while (true) {
                string nextFolder = modfolder.GetNext();
                // don't keep looking for mods forever, that would be bad
                if (nextFolder == "")
                    break;
                
                if (modfolder.CurrentIsDir()) {
                    mods.Add(nextFolder);
                }
            }
        }

        foreach (var item in mods) {
            GD.Print("Loaded mod: " + item);
        }
    }
}