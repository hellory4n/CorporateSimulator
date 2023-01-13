using Godot;
using System;
using System.Collections.Generic;

public class PhoneStorage : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneStorageButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"64", "6", "20"});
        cpus.Add(new List<object>{"128", "7", "30"});
        cpus.Add(new List<object>{"256", "8", "90"});
        cpus.Add(new List<object>{"512", "9", "180"});
        cpus.Add(new List<object>{"1000", "10", "360"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneStorageButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
