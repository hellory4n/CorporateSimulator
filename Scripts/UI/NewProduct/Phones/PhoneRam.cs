using Godot;
using System;
using System.Collections.Generic;

public class PhoneRam : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneRamButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"1", "10", "3"});
        cpus.Add(new List<object>{"2", "20", "5"});
        cpus.Add(new List<object>{"4", "30", "8"});
        cpus.Add(new List<object>{"8", "40", "9"});
        cpus.Add(new List<object>{"16", "50", "10"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneRamButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
