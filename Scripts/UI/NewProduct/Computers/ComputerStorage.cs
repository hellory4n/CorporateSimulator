using Godot;
using System;
using System.Collections.Generic;

public class ComputerStorage : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ComputerStorageButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial: storage edition
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"SSD", "8000", "10", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "9", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "8", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "7", "90"});
            cpus.Add(new List<object>{"SSD", "500", "6", "30"});
            cpus.Add(new List<object>{"SSD", "250", "5", "20"});
            cpus.Add(new List<object>{"HDD", "8000", "9", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "8", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "7", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "6", "45"});
            cpus.Add(new List<object>{"HDD", "500", "5", "15"});
            cpus.Add(new List<object>{"HDD", "250", "4", "10"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"SSD", "16000", "10", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "9", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "8", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "7", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "6", "90"});
            cpus.Add(new List<object>{"SSD", "500", "5", "30"});
            cpus.Add(new List<object>{"SSD", "250", "4", "20"});
            cpus.Add(new List<object>{"HDD", "16000", "9", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "8", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "7", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "6", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "5", "45"});
            cpus.Add(new List<object>{"HDD", "500", "4", "15"});
            cpus.Add(new List<object>{"HDD", "250", "3", "10"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"SSD", "32000", "10", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "9", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "8", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "7", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "6", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "5", "90"});
            cpus.Add(new List<object>{"SSD", "500", "4", "30"});
            cpus.Add(new List<object>{"SSD", "250", "3", "20"});
            cpus.Add(new List<object>{"HDD", "32000", "9", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "8", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "7", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "6", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "5", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "4", "45"});
            cpus.Add(new List<object>{"HDD", "500", "3", "15"});
            cpus.Add(new List<object>{"HDD", "250", "2", "10"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"SSD", "64000", "10", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "9", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "8", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "7", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "6", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "5", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "4", "90"});
            cpus.Add(new List<object>{"SSD", "500", "3", "30"});
            cpus.Add(new List<object>{"SSD", "250", "2", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "9", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "8", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "7", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "6", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "5", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "4", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "3", "45"});
            cpus.Add(new List<object>{"HDD", "500", "2", "15"});
            cpus.Add(new List<object>{"HDD", "250", "1", "10"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"SSD 2", "128000", "10", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "9", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "8", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "7", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "6", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "5", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "9", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "8", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "7", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "6", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "5", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "4", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "3", "90"});
            cpus.Add(new List<object>{"SSD", "500", "2", "30"});
            cpus.Add(new List<object>{"SSD", "250", "1", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "7", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "6", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "5", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "4", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "3", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "2", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "1", "45"});
            cpus.Add(new List<object>{"HDD", "500", "0", "15"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"SSD 2", "250000", "10", "1800"});
            cpus.Add(new List<object>{"SSD 2", "128000", "9", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "8", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "7", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "6", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "5", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "4", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "8", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "7", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "6", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "5", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "4", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "3", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "2", "90"});
            cpus.Add(new List<object>{"SSD", "500", "1", "30"});
            cpus.Add(new List<object>{"SSD", "250", "0", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "6", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "5", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "4", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "3", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "2", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "1", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "0", "45"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"SSD 2", "500000", "10", "2000"});
            cpus.Add(new List<object>{"SSD 2", "250000", "9", "1800"});
            cpus.Add(new List<object>{"SSD 2", "128000", "8", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "7", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "6", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "5", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "4", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "3", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "7", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "6", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "5", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "4", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "3", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "2", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "1", "90"});
            cpus.Add(new List<object>{"SSD", "500", "0", "30"});
            cpus.Add(new List<object>{"HDD", "64000", "5", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "4", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "3", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "2", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "1", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "0", "100"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"SSD 2", "1000000", "10", "2200"});
            cpus.Add(new List<object>{"SSD 2", "500000", "9", "2000"});
            cpus.Add(new List<object>{"SSD 2", "250000", "8", "1800"});
            cpus.Add(new List<object>{"SSD 2", "128000", "7", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "6", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "5", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "4", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "3", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "2", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "6", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "5", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "4", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "3", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "2", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "1", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "0", "90"});
            cpus.Add(new List<object>{"HDD", "64000", "4", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "3", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "2", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "1", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "0", "150"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"SSD 2", "2000000", "10", "2400"});
            cpus.Add(new List<object>{"SSD 2", "1000000", "9", "2200"});
            cpus.Add(new List<object>{"SSD 2", "500000", "8", "2000"});
            cpus.Add(new List<object>{"SSD 2", "250000", "7", "1800"});
            cpus.Add(new List<object>{"SSD 2", "128000", "6", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "5", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "4", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "3", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "2", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "1", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "5", "1600"});
            cpus.Add(new List<object>{"SSD", "32000", "4", "1400"});
            cpus.Add(new List<object>{"SSD", "16000", "3", "1200"});
            cpus.Add(new List<object>{"SSD", "8000", "2", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "1", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "0", "200"});
            cpus.Add(new List<object>{"HDD", "64000", "3", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "2", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "1", "600"});
            cpus.Add(new List<object>{"HDD", "8000", "0", "500"});
        } else if (Global.Year == 10) {
            cpus.Add(new List<object>{"SSD 2", "4000000", "10", "2600"});
            cpus.Add(new List<object>{"SSD 2", "2000000", "9", "2400"});
            cpus.Add(new List<object>{"SSD 2", "1000000", "8", "2200"});
            cpus.Add(new List<object>{"SSD 2", "500000", "7", "2000"});
            cpus.Add(new List<object>{"SSD 2", "250000", "6", "1800"});
            cpus.Add(new List<object>{"SSD 2", "128000", "5", "1600"});
            cpus.Add(new List<object>{"SSD 2", "64000", "4", "1400"});
            cpus.Add(new List<object>{"SSD 2", "32000", "3", "1200"});
            cpus.Add(new List<object>{"SSD 2", "16000", "2", "1000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "1", "800"});
            cpus.Add(new List<object>{"SSD 2", "4000", "0", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "4", "1300"});
            cpus.Add(new List<object>{"SSD", "32000", "3", "1200"});
            cpus.Add(new List<object>{"SSD", "16000", "2", "1100"});
            cpus.Add(new List<object>{"SSD", "8000", "1", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "0", "300"});
            cpus.Add(new List<object>{"HDD", "64000", "2", "800"});
            cpus.Add(new List<object>{"HDD", "32000", "1", "700"});
            cpus.Add(new List<object>{"HDD", "16000", "0", "600"});
        }
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (ComputerStorageButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
