using Godot;
using System;
using System.Collections.Generic;

public class ComputerRAM : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerRAMButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial but i forgor get it haha peak comedy 
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"128", "200", "10"});
            cpus.Add(new List<object>{"64", "100", "9"});
            cpus.Add(new List<object>{"32", "70", "8"});
            cpus.Add(new List<object>{"16", "50", "7"});
            cpus.Add(new List<object>{"8", "40", "5"});
            cpus.Add(new List<object>{"4", "30", "3"});
            cpus.Add(new List<object>{"2", "20", "2"});
            cpus.Add(new List<object>{"1", "10", "1"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"256", "400", "10"});
            cpus.Add(new List<object>{"128", "200", "9"});
            cpus.Add(new List<object>{"64", "100", "8"});
            cpus.Add(new List<object>{"32", "70", "7"});
            cpus.Add(new List<object>{"16", "50", "6"});
            cpus.Add(new List<object>{"8", "40", "4"});
            cpus.Add(new List<object>{"4", "30", "2"});
            cpus.Add(new List<object>{"2", "20", "1"});
            cpus.Add(new List<object>{"1", "10", "0"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"512", "800", "10"});
            cpus.Add(new List<object>{"256", "400", "9"});
            cpus.Add(new List<object>{"128", "200", "8"});
            cpus.Add(new List<object>{"64", "100", "7"});
            cpus.Add(new List<object>{"32", "70", "6"});
            cpus.Add(new List<object>{"16", "50", "5"});
            cpus.Add(new List<object>{"8", "40", "3"});
            cpus.Add(new List<object>{"4", "30", "1"});
            cpus.Add(new List<object>{"2", "20", "0"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"1024", "1600", "10"});
            cpus.Add(new List<object>{"512", "800", "9"});
            cpus.Add(new List<object>{"256", "400", "8"});
            cpus.Add(new List<object>{"128", "200", "7"});
            cpus.Add(new List<object>{"64", "100", "6"});
            cpus.Add(new List<object>{"32", "70", "5"});
            cpus.Add(new List<object>{"16", "50", "4"});
            cpus.Add(new List<object>{"8", "40", "2"});
            cpus.Add(new List<object>{"4", "30", "0"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"2048", "3200", "10"});
            cpus.Add(new List<object>{"1024", "1600", "9"});
            cpus.Add(new List<object>{"512", "800", "8"});
            cpus.Add(new List<object>{"256", "400", "7"});
            cpus.Add(new List<object>{"128", "200", "6"});
            cpus.Add(new List<object>{"64", "100", "5"});
            cpus.Add(new List<object>{"32", "70", "4"});
            cpus.Add(new List<object>{"16", "50", "3"});
            cpus.Add(new List<object>{"8", "40", "1"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"4096", "6400", "10"});
            cpus.Add(new List<object>{"2048", "3200", "9"});
            cpus.Add(new List<object>{"1024", "1600", "8"});
            cpus.Add(new List<object>{"512", "800", "7"});
            cpus.Add(new List<object>{"256", "400", "6"});
            cpus.Add(new List<object>{"128", "200", "5"});
            cpus.Add(new List<object>{"64", "100", "4"});
            cpus.Add(new List<object>{"32", "70", "3"});
            cpus.Add(new List<object>{"16", "50", "2"});
            cpus.Add(new List<object>{"8", "40", "0"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"8192", "12800", "10"});
            cpus.Add(new List<object>{"4096", "6400", "9"});
            cpus.Add(new List<object>{"2048", "3200", "8"});
            cpus.Add(new List<object>{"1024", "1600", "7"});
            cpus.Add(new List<object>{"512", "800", "6"});
            cpus.Add(new List<object>{"256", "400", "5"});
            cpus.Add(new List<object>{"128", "200", "4"});
            cpus.Add(new List<object>{"64", "100", "3"});
            cpus.Add(new List<object>{"32", "70", "2"});
            cpus.Add(new List<object>{"16", "50", "1"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"16384", "25600", "10"});
            cpus.Add(new List<object>{"8192", "12800", "9"});
            cpus.Add(new List<object>{"4096", "6400", "8"});
            cpus.Add(new List<object>{"2048", "3200", "7"});
            cpus.Add(new List<object>{"1024", "1600", "6"});
            cpus.Add(new List<object>{"512", "800", "5"});
            cpus.Add(new List<object>{"256", "400", "4"});
            cpus.Add(new List<object>{"128", "200", "3"});
            cpus.Add(new List<object>{"64", "100", "2"});
            cpus.Add(new List<object>{"32", "70", "1"});
            cpus.Add(new List<object>{"16", "50", "0"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"32768", "51200", "10"});
            cpus.Add(new List<object>{"16384", "25600", "9"});
            cpus.Add(new List<object>{"8192", "12800", "8"});
            cpus.Add(new List<object>{"4096", "6400", "7"});
            cpus.Add(new List<object>{"2048", "3200", "6"});
            cpus.Add(new List<object>{"1024", "1600", "5"});
            cpus.Add(new List<object>{"512", "800", "4"});
            cpus.Add(new List<object>{"256", "400", "3"});
            cpus.Add(new List<object>{"128", "200", "2"});
            cpus.Add(new List<object>{"64", "100", "1"});
            cpus.Add(new List<object>{"32", "70", "0"});
        } else if (Global.Year == 10) {
            cpus.Add(new List<object>{"65536", "102400", "10"});
            cpus.Add(new List<object>{"32768", "51200", "9"});
            cpus.Add(new List<object>{"16384", "25600", "8"});
            cpus.Add(new List<object>{"8192", "12800", "7"});
            cpus.Add(new List<object>{"4096", "6400", "6"});
            cpus.Add(new List<object>{"2048", "3200", "5"});
            cpus.Add(new List<object>{"1024", "1600", "4"});
            cpus.Add(new List<object>{"512", "800", "3"});
            cpus.Add(new List<object>{"256", "400", "2"});
            cpus.Add(new List<object>{"128", "200", "1"});
            cpus.Add(new List<object>{"64", "100", "0"});
        }
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
