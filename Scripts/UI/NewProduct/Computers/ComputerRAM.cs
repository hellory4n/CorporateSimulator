using Godot;
using System;
using System.Collections.Generic;

public class ComputerRAM : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerRAMButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial but i forgor get it haha peak comedy 
        cpus.Add(new List<object>{"1", "10", "1"});
        cpus.Add(new List<object>{"2", "20", "2"});
        cpus.Add(new List<object>{"4", "30", "3"});
        cpus.Add(new List<object>{"8", "40", "5"});
        cpus.Add(new List<object>{"16", "50", "7"});
        cpus.Add(new List<object>{"32", "70", "8"});
        cpus.Add(new List<object>{"64", "100", "9"});
        cpus.Add(new List<object>{"128", "200", "10"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerRAMButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
