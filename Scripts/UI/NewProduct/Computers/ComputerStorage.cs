using Godot;
using System;
using System.Collections.Generic;

public class ComputerStorage : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerStorageButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial: storage edition
        cpus.Add(new List<object>{"SSD", "250", "5", "20"});
        cpus.Add(new List<object>{"SSD", "500", "6", "30"});
        cpus.Add(new List<object>{"SSD", "1000", "7", "90"});
        cpus.Add(new List<object>{"SSD", "2000", "8", "200"});
        cpus.Add(new List<object>{"SSD", "4000", "9", "300"});
        cpus.Add(new List<object>{"SSD", "8000", "10", "1000"});
        cpus.Add(new List<object>{"HDD", "250", "4", "10"});
        cpus.Add(new List<object>{"HDD", "500", "5", "15"});
        cpus.Add(new List<object>{"HDD", "1000", "6", "45"});
        cpus.Add(new List<object>{"HDD", "2000", "7", "100"});
        cpus.Add(new List<object>{"HDD", "4000", "8", "150"});
        cpus.Add(new List<object>{"HDD", "8000", "9", "500"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerStorageButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
