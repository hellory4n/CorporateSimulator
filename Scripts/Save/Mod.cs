using System;
using System.Collections.Generic;
using Godot;

public class Mod : Node2D {
    public override void _Ready() {
        // load cool mods :)
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

        foreach (var coolMod in mods) {
            // now we have to find a script
            File modfile = new File();
            if (modfile.FileExists($"user://mods/{coolMod}/main.tscn")) {
                var yes = (PackedScene)ResourceLoader.Load($"user://mods/{coolMod}/main.tscn");
                Node2D OK = (Node2D)yes.Instance();
                GetTree().Root.CallDeferred("add_child", OK);
            }
            GD.Print("Loaded mod: " + coolMod);
        }
        base._Ready();
    }
}