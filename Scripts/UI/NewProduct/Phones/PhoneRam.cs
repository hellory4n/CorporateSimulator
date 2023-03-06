using Godot;
using System;
using System.Collections.Generic;

public class PhoneRam : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneRamButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"16", "50", "10"});
            cpus.Add(new List<object>{"8", "40", "9"});
            cpus.Add(new List<object>{"4", "30", "8"});
            cpus.Add(new List<object>{"2", "20", "5"});
            cpus.Add(new List<object>{"1", "10", "3"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"32", "60", "10"});
            cpus.Add(new List<object>{"16", "50", "9"});
            cpus.Add(new List<object>{"8", "40", "8"});
            cpus.Add(new List<object>{"4", "30", "7"});
            cpus.Add(new List<object>{"2", "20", "4"});
            cpus.Add(new List<object>{"1", "10", "2"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"64", "70", "10"});
            cpus.Add(new List<object>{"32", "60", "9"});
            cpus.Add(new List<object>{"16", "50", "8"});
            cpus.Add(new List<object>{"8", "40", "7"});
            cpus.Add(new List<object>{"4", "30", "6"});
            cpus.Add(new List<object>{"2", "20", "3"});
            cpus.Add(new List<object>{"1", "10", "1"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"128", "80", "10"});
            cpus.Add(new List<object>{"64", "70", "9"});
            cpus.Add(new List<object>{"32", "60", "8"});
            cpus.Add(new List<object>{"16", "50", "7"});
            cpus.Add(new List<object>{"8", "40", "6"});
            cpus.Add(new List<object>{"4", "30", "5"});
            cpus.Add(new List<object>{"2", "20", "2"});
            cpus.Add(new List<object>{"1", "10", "0"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"256", "90", "10"});
            cpus.Add(new List<object>{"128", "80", "9"});
            cpus.Add(new List<object>{"64", "70", "8"});
            cpus.Add(new List<object>{"32", "60", "7"});
            cpus.Add(new List<object>{"16", "50", "6"});
            cpus.Add(new List<object>{"8", "40", "5"});
            cpus.Add(new List<object>{"4", "30", "4"});
            cpus.Add(new List<object>{"2", "20", "1"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"512", "100", "10"});
            cpus.Add(new List<object>{"256", "90", "9"});
            cpus.Add(new List<object>{"128", "80", "8"});
            cpus.Add(new List<object>{"64", "70", "7"});
            cpus.Add(new List<object>{"32", "60", "6"});
            cpus.Add(new List<object>{"16", "50", "5"});
            cpus.Add(new List<object>{"8", "40", "4"});
            cpus.Add(new List<object>{"4", "30", "3"});
            cpus.Add(new List<object>{"2", "20", "0"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"1024", "110", "10"});
            cpus.Add(new List<object>{"512", "100", "9"});
            cpus.Add(new List<object>{"256", "90", "8"});
            cpus.Add(new List<object>{"128", "80", "7"});
            cpus.Add(new List<object>{"64", "70", "6"});
            cpus.Add(new List<object>{"32", "60", "5"});
            cpus.Add(new List<object>{"16", "50", "4"});
            cpus.Add(new List<object>{"8", "40", "3"});
            cpus.Add(new List<object>{"4", "30", "2"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"2048", "120", "10"});
            cpus.Add(new List<object>{"1024", "110", "9"});
            cpus.Add(new List<object>{"512", "100", "8"});
            cpus.Add(new List<object>{"256", "90", "7"});
            cpus.Add(new List<object>{"128", "80", "6"});
            cpus.Add(new List<object>{"64", "70", "5"});
            cpus.Add(new List<object>{"32", "60", "4"});
            cpus.Add(new List<object>{"16", "50", "3"});
            cpus.Add(new List<object>{"8", "40", "2"});
            cpus.Add(new List<object>{"4", "30", "1"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"4096", "130", "10"});
            cpus.Add(new List<object>{"2048", "120", "9"});
            cpus.Add(new List<object>{"1024", "110", "8"});
            cpus.Add(new List<object>{"512", "100", "7"});
            cpus.Add(new List<object>{"256", "90", "6"});
            cpus.Add(new List<object>{"128", "80", "5"});
            cpus.Add(new List<object>{"64", "70", "4"});
            cpus.Add(new List<object>{"32", "60", "3"});
            cpus.Add(new List<object>{"16", "50", "2"});
            cpus.Add(new List<object>{"8", "40", "1"});
            cpus.Add(new List<object>{"4", "30", "0"});
        } else if (Global.Year == 10) {
            cpus.Add(new List<object>{"8192", "140", "10"});
            cpus.Add(new List<object>{"4096", "130", "9"});
            cpus.Add(new List<object>{"2048", "120", "8"});
            cpus.Add(new List<object>{"1024", "110", "7"});
            cpus.Add(new List<object>{"512", "100", "6"});
            cpus.Add(new List<object>{"256", "90", "5"});
            cpus.Add(new List<object>{"128", "80", "4"});
            cpus.Add(new List<object>{"64", "70", "3"});
            cpus.Add(new List<object>{"32", "60", "2"});
            cpus.Add(new List<object>{"16", "50", "1"});
            cpus.Add(new List<object>{"8", "40", "0"});
        }
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
