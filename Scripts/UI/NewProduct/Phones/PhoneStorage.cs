using Godot;
using System;
using System.Collections.Generic;

public class PhoneStorage : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneStorageButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"1024", "10", "360"});
            cpus.Add(new List<object>{"512", "9", "180"});
            cpus.Add(new List<object>{"256", "8", "90"});
            cpus.Add(new List<object>{"128", "7", "30"});
            cpus.Add(new List<object>{"64", "6", "20"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"2048", "10", "400"});
            cpus.Add(new List<object>{"1024", "9", "360"});
            cpus.Add(new List<object>{"512", "8", "180"});
            cpus.Add(new List<object>{"256", "7", "90"});
            cpus.Add(new List<object>{"128", "6", "30"});
            cpus.Add(new List<object>{"64", "5", "20"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"4096", "10", "500"});
            cpus.Add(new List<object>{"2048", "9", "400"});
            cpus.Add(new List<object>{"1024", "8", "360"});
            cpus.Add(new List<object>{"512", "7", "180"});
            cpus.Add(new List<object>{"256", "6", "90"});
            cpus.Add(new List<object>{"128", "5", "30"});
            cpus.Add(new List<object>{"64", "4", "20"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"8192", "10", "600"});
            cpus.Add(new List<object>{"4096", "9", "500"});
            cpus.Add(new List<object>{"2048", "8", "400"});
            cpus.Add(new List<object>{"1024", "7", "360"});
            cpus.Add(new List<object>{"512", "6", "180"});
            cpus.Add(new List<object>{"256", "5", "90"});
            cpus.Add(new List<object>{"128", "4", "30"});
            cpus.Add(new List<object>{"64", "3", "20"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"16384", "10", "700"});
            cpus.Add(new List<object>{"8192", "9", "600"});
            cpus.Add(new List<object>{"4096", "8", "500"});
            cpus.Add(new List<object>{"2048", "7", "400"});
            cpus.Add(new List<object>{"1024", "6", "360"});
            cpus.Add(new List<object>{"512", "5", "180"});
            cpus.Add(new List<object>{"256", "4", "90"});
            cpus.Add(new List<object>{"128", "3", "30"});
            cpus.Add(new List<object>{"64", "2", "20"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"32768", "10", "800"});
            cpus.Add(new List<object>{"16384", "9", "700"});
            cpus.Add(new List<object>{"8192", "8", "600"});
            cpus.Add(new List<object>{"4096", "7", "500"});
            cpus.Add(new List<object>{"2048", "6", "400"});
            cpus.Add(new List<object>{"1024", "5", "360"});
            cpus.Add(new List<object>{"512", "4", "180"});
            cpus.Add(new List<object>{"256", "3", "90"});
            cpus.Add(new List<object>{"128", "2", "30"});
            cpus.Add(new List<object>{"64", "1", "20"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"65536", "10", "900"});
            cpus.Add(new List<object>{"32768", "9", "800"});
            cpus.Add(new List<object>{"16384", "8", "700"});
            cpus.Add(new List<object>{"8192", "7", "600"});
            cpus.Add(new List<object>{"4096", "6", "500"});
            cpus.Add(new List<object>{"2048", "5", "400"});
            cpus.Add(new List<object>{"1024", "4", "360"});
            cpus.Add(new List<object>{"512", "3", "180"});
            cpus.Add(new List<object>{"256", "2", "90"});
            cpus.Add(new List<object>{"128", "1", "30"});
            cpus.Add(new List<object>{"64", "0", "20"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"131072", "10", "1000"});
            cpus.Add(new List<object>{"65536", "9", "900"});
            cpus.Add(new List<object>{"32768", "8", "800"});
            cpus.Add(new List<object>{"16384", "7", "700"});
            cpus.Add(new List<object>{"8192", "6", "600"});
            cpus.Add(new List<object>{"4096", "5", "500"});
            cpus.Add(new List<object>{"2048", "4", "400"});
            cpus.Add(new List<object>{"1024", "3", "360"});
            cpus.Add(new List<object>{"512", "2", "180"});
            cpus.Add(new List<object>{"256", "1", "90"});
            cpus.Add(new List<object>{"128", "0", "30"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"262144", "10", "1100"});
            cpus.Add(new List<object>{"131072", "9", "1000"});
            cpus.Add(new List<object>{"65536", "8", "900"});
            cpus.Add(new List<object>{"32768", "7", "800"});
            cpus.Add(new List<object>{"16384", "6", "700"});
            cpus.Add(new List<object>{"8192", "5", "600"});
            cpus.Add(new List<object>{"4096", "4", "500"});
            cpus.Add(new List<object>{"2048", "3", "400"});
            cpus.Add(new List<object>{"1024", "2", "360"});
            cpus.Add(new List<object>{"512", "1", "180"});
            cpus.Add(new List<object>{"256", "0", "90"});
        } else if (Global.Year > 9) {
            cpus.Add(new List<object>{"524288", "10", "1200"});
            cpus.Add(new List<object>{"262144", "9", "1100"});
            cpus.Add(new List<object>{"131072", "8", "1000"});
            cpus.Add(new List<object>{"65536", "7", "900"});
            cpus.Add(new List<object>{"32768", "6", "800"});
            cpus.Add(new List<object>{"16384", "5", "700"});
            cpus.Add(new List<object>{"8192", "4", "600"});
            cpus.Add(new List<object>{"4096", "3", "500"});
            cpus.Add(new List<object>{"2048", "2", "400"});
            cpus.Add(new List<object>{"1024", "1", "360"});
            cpus.Add(new List<object>{"512", "0", "180"});
        }
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
