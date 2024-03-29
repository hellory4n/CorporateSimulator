using Godot;
using System;
using System.Collections.Generic;

public class ModList : VBoxContainer {
    public override void _Ready() {
        // find mods :)
        Directory modfolder = new Directory();
        List<string> mods = new List<string>();
        if (modfolder.DirExists("user://mods")) {
            modfolder.Open("user://mods/");
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
            modfolder.ListDirEnd();
        }

        // make a massive mess
        if (mods.Count > 0) {
            foreach (var mod in mods) {
                // control is required to make it show properly in the scroll thing, node2d is so i can make it have
                // a cooler look and stuff
                Control whytho = new Control();
                Node2D sillyness = new Node2D();

                whytho.RectMinSize = new Vector2(890, 84);
                AddChild(whytho);
                whytho.AddChild(sillyness);

                // epic font :)
                DynamicFont font = new DynamicFont();
                font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Bold.ttf");
                font.Size = 40;

                // mod name
                Label name = new Label();
                name.Text = mod;
                name.AddColorOverride("font_color", new Color(0,0,0,1));
                name.AddFontOverride("font", font);
                name.RectPosition = new Vector2(10, 0);
                name.Valign = Label.VAlign.Center;
                name.RectSize = new Vector2(580, 84);
                name.ClipText = true;
                sillyness.AddChild(name);

                // very much epic button
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/ModManagerRemoveMod.tscn");
                RemoveMod OK = (RemoveMod)yes.Instance();
                OK.RectPosition = new Vector2(570, 4);
                OK.Init($"user://mods/{mod}");
                sillyness.AddChild(OK);
            }
        } else {
            // epic font :)
            DynamicFont font = new DynamicFont();
            font.FontData = ResourceLoader.Load<DynamicFontData>("res://Uhh/Ubuntu-Regular.ttf");
            font.Size = 24;

            // uh oh you don't have mods, download malware NOW!
            Label doitnow = new Label();
            doitnow.Text = "You don't have any mods. Get some from our Discord server!";
            doitnow.AddColorOverride("font_color", new Color(0,0,0,1));
            doitnow.AddFontOverride("font", font);
            doitnow.RectPosition = new Vector2(0, 95);
            doitnow.Align = Label.AlignEnum.Center;
            doitnow.Valign = Label.VAlign.Center;
            doitnow.RectMinSize = new Vector2(890, 290);

            AddChild(doitnow);
        }
        base._Ready();
    }
}