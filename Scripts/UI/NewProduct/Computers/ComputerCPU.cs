using Godot;
using System;
using System.Collections.Generic;

public class ComputerCPU : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerCPUButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"In Tells", "u9 13th gen", "10", "600"});
        cpus.Add(new List<object>{"In Tells", "u7 13th gen", "9", "400"});
        cpus.Add(new List<object>{"In Tells", "u5 13th gen", "8", "300"});
        cpus.Add(new List<object>{"In Tells", "u3 13th gen", "7", "100"});
        cpus.Add(new List<object>{"In Tells", "u9 10th gen", "9", "300"});
        cpus.Add(new List<object>{"In Tells", "u7 10th gen", "8", "200"});
        cpus.Add(new List<object>{"In Tells", "u5 10th gen", "7", "125"});
        cpus.Add(new List<object>{"In Tells", "u3 10th gen", "6", "75"});
        cpus.Add(new List<object>{"In Tells", "u7 7th gen", "7", "300"});
        cpus.Add(new List<object>{"In Tells", "u5 7th gen", "6", "150"});
        cpus.Add(new List<object>{"In Tells", "u3 7th gen", "5", "100"});
        cpus.Add(new List<object>{"In Tells", "u7 3rd gen", "4", "135"});
        cpus.Add(new List<object>{"In Tells", "u5 3rd gen", "3", "100"});
        cpus.Add(new List<object>{"In Tells", "u3 3rd gen", "2", "50"});
        cpus.Add(new List<object>{"AND", "Rise 9 7000", "10", "500"});
        cpus.Add(new List<object>{"AND", "Rise 7 7000", "9", "300"});
        cpus.Add(new List<object>{"AND", "Rise 5 7000", "8", "200"});
        cpus.Add(new List<object>{"AND", "Rise 9 5000", "9", "300"});
        cpus.Add(new List<object>{"AND", "Rise 7 5000", "8", "200"});
        cpus.Add(new List<object>{"AND", "Rise 5 5000", "7", "100"});
        cpus.Add(new List<object>{"AND", "Rise 9 3000", "8", "300"});
        cpus.Add(new List<object>{"AND", "Rise 7 3000", "7", "275"});
        cpus.Add(new List<object>{"AND", "Rise 5 3000", "6", "200"});
        cpus.Add(new List<object>{"AND", "Rise 3 3000", "5", "150"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerCPUButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
