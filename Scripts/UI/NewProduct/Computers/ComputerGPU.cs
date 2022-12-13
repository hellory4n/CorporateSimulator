using Godot;
using System;
using System.Collections.Generic;

public class ComputerGPU : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerGPUButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial: gpu edition
        cpus.Add(new List<object>{"Novideo", "4090", "10", "2000"});
        cpus.Add(new List<object>{"Novideo", "4080", "9", "1500"});
        cpus.Add(new List<object>{"Novideo", "4070", "8", "1200"});
        cpus.Add(new List<object>{"Novideo", "4060", "7", "1000"});
        cpus.Add(new List<object>{"Novideo", "3090", "9", "1750"});
        cpus.Add(new List<object>{"Novideo", "3080", "8", "1200"});
        cpus.Add(new List<object>{"Novideo", "3070", "7", "800"});
        cpus.Add(new List<object>{"Novideo", "3060", "6", "400"});
        cpus.Add(new List<object>{"Novideo", "2080", "8", "1000"});
        cpus.Add(new List<object>{"Novideo", "2070", "7", "800"});
        cpus.Add(new List<object>{"Novideo", "2060", "6", "200"});
        cpus.Add(new List<object>{"Novideo", "1080", "7", "800"});
        cpus.Add(new List<object>{"Novideo", "1070", "6", "600"});
        cpus.Add(new List<object>{"Novideo", "1060", "5", "400"});
        cpus.Add(new List<object>{"Novideo", "1050", "4", "200"});
        cpus.Add(new List<object>{"AND", "6900", "10", "1200"});
        cpus.Add(new List<object>{"AND", "6800", "9", "800"});
        cpus.Add(new List<object>{"AND", "6700", "8", "500"});
        cpus.Add(new List<object>{"AND", "6600", "7", "300"});
        cpus.Add(new List<object>{"AND", "6500", "6", "150"});
        cpus.Add(new List<object>{"AND", "6400", "5", "100"});
        cpus.Add(new List<object>{"AND", "5700", "8", "600"});
        cpus.Add(new List<object>{"AND", "5600", "7", "300"});
        cpus.Add(new List<object>{"AND", "5500", "6", "200"});
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerGPUButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
