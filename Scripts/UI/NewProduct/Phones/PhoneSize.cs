using Godot;
using System;
using System.Collections.Generic;

public class PhoneSize : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneSizeButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"7", "10", "50"});
        cpus.Add(new List<object>{"6.5", "9", "45"});
        cpus.Add(new List<object>{"6", "8", "40"});
        cpus.Add(new List<object>{"5.5", "7", "35"});
        cpus.Add(new List<object>{"5", "6", "30"});
        cpus.Add(new List<object>{"4.5", "5", "25"});
        cpus.Add(new List<object>{"4", "4", "20"});
        cpus.Add(new List<object>{"3.5", "3", "15"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneSizeButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
