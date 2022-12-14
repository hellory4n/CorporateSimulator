using Godot;
using System;
using System.Collections.Generic;

public class ComputerOS : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerOSButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region operating ohio 30 day trial system
        cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "9", "200"});
        cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "8", "140"});
        cpus.Add(new List<object>{"Macrohard", "Doors 10 Pro", "10", "200"});
        cpus.Add(new List<object>{"Macrohard", "Doors 10 Home", "9", "140"});
        cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "7", "0"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerOSButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
