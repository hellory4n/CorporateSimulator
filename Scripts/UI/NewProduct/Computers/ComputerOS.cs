using Godot;
using System;
using System.Collections.Generic;

public class ComputerOS : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerOSButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region operating ohio 30 day trial system
        for (int i = Global.CustomOS.Count - 1; i >= 0 ; i--) {
            Product os = Global.CustomOS[i];
            cpus.Add(new List<object>{Global.CompanyName, os.Name, os.Rating.ToString(), "10"});
        }
        if (Global.Year == 1 || Global.Year == 2) {
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "9", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "8", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Pro", "10", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Home", "9", "140"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "7", "0"});
        } else if (Global.Year == 3 || Global.Year == 4) {
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Pro", "10", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Home", "9", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "8", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "7", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Pro", "9", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Home", "8", "140"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 2", "8", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "7", "0"});
        } else if (Global.Year == 5 || Global.Year == 6) {
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Pro", "10", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Home", "9", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Pro", "9", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Home", "8", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "7", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "6", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Pro", "8", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Home", "7", "140"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 3", "9", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 2", "8", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "7", "0"});
        } else if (Global.Year == 7 || Global.Year == 8) {
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Twice Pro", "10", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Twice Home", "9", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Pro", "9", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Home", "8", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Pro", "8", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Home", "7", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "6", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "5", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Pro", "7", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 10 Home", "6", "140"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS XD", "10", "1"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 3", "9", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 2", "8", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "7", "0"});
        } else if (Global.Year > 8) {
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Thrice Pro", "10", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Thrice Home", "9", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Twice Pro", "9", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Twice Home", "8", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Pro", "8", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors Infinity Home", "7", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Pro", "7", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 12 Home", "6", "140"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Pro", "5", "200"});
            cpus.Add(new List<object>{"Macrohard", "Doors 11 Home", "4", "140"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS H", "10", "2"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS XD", "9", "1"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 3", "8", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS 2", "7", "0"});
            cpus.Add(new List<object>{"Penguin Co", "PenguinOS", "6", "0"});
        }
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
