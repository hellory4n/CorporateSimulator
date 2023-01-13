using Godot;
using System;
using System.Collections.Generic;

public class PhoneBattery : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneBatteryButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"24", "10", "30"});
        cpus.Add(new List<object>{"18", "9", "25"});
        cpus.Add(new List<object>{"12", "8", "20"});
        cpus.Add(new List<object>{"8", "7", "15"});
        cpus.Add(new List<object>{"4", "6", "10"});
        cpus.Add(new List<object>{"2", "5", "5"});
        cpus.Add(new List<object>{"1", "4", "2"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneBatteryButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
