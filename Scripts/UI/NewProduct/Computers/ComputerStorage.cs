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
            cpus.Add(new List<object>{"SSD", "16000", "10", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "9", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "8", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "7", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "6", "90"});
            cpus.Add(new List<object>{"SSD", "500", "5", "30"});
            cpus.Add(new List<object>{"SSD", "250", "4", "20"});
            cpus.Add(new List<object>{"HDD", "16000", "9", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "8", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "7", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "6", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "5", "45"});
            cpus.Add(new List<object>{"HDD", "500", "4", "15"});
            cpus.Add(new List<object>{"HDD", "250", "3", "10"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"SSD", "32000", "10", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "9", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "8", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "7", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "6", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "5", "90"});
            cpus.Add(new List<object>{"SSD", "500", "4", "30"});
            cpus.Add(new List<object>{"SSD", "250", "3", "20"});
            cpus.Add(new List<object>{"HDD", "32000", "9", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "8", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "7", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "6", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "5", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "4", "45"});
            cpus.Add(new List<object>{"HDD", "500", "3", "15"});
            cpus.Add(new List<object>{"HDD", "250", "2", "10"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"SSD", "64000", "10", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "9", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "8", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "7", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "6", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "5", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "4", "90"});
            cpus.Add(new List<object>{"SSD", "500", "3", "30"});
            cpus.Add(new List<object>{"SSD", "250", "2", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "9", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "8", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "7", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "6", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "5", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "4", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "3", "45"});
            cpus.Add(new List<object>{"HDD", "500", "2", "15"});
            cpus.Add(new List<object>{"HDD", "250", "1", "10"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"SSD 2", "128000", "10", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "9", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "8", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "7", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "6", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "5", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "9", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "8", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "7", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "6", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "5", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "4", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "3", "90"});
            cpus.Add(new List<object>{"SSD", "500", "2", "30"});
            cpus.Add(new List<object>{"SSD", "250", "1", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "7", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "6", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "5", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "4", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "3", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "2", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "1", "45"});
            cpus.Add(new List<object>{"HDD", "500", "0", "15"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"SSD 2", "256000", "10", "48000"});
            cpus.Add(new List<object>{"SSD 2", "128000", "9", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "8", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "7", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "6", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "5", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "4", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "8", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "7", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "6", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "5", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "4", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "3", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "2", "90"});
            cpus.Add(new List<object>{"SSD", "500", "1", "30"});
            cpus.Add(new List<object>{"SSD", "250", "0", "20"});
            cpus.Add(new List<object>{"HDD", "64000", "6", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "5", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "4", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "3", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "2", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "1", "100"});
            cpus.Add(new List<object>{"HDD", "1000", "0", "45"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"SSD 2", "512000", "10", "96000"});
            cpus.Add(new List<object>{"SSD 2", "256000", "9", "48000"});
            cpus.Add(new List<object>{"SSD 2", "128000", "8", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "7", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "6", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "5", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "4", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "3", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "7", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "6", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "5", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "4", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "3", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "2", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "1", "90"});
            cpus.Add(new List<object>{"SSD", "500", "0", "30"});
            cpus.Add(new List<object>{"HDD", "64000", "5", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "4", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "3", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "2", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "1", "150"});
            cpus.Add(new List<object>{"HDD", "2000", "0", "100"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"SSD 2", "1024000", "10", "192000"});
            cpus.Add(new List<object>{"SSD 2", "512000", "9", "96000"});
            cpus.Add(new List<object>{"SSD 2", "256000", "8", "48000"});
            cpus.Add(new List<object>{"SSD 2", "128000", "7", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "6", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "5", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "4", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "3", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "2", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "6", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "5", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "4", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "3", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "2", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "1", "200"});
            cpus.Add(new List<object>{"SSD", "1000", "0", "90"});
            cpus.Add(new List<object>{"HDD", "64000", "4", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "3", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "2", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "1", "500"});
            cpus.Add(new List<object>{"HDD", "4000", "0", "150"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"SSD 2", "2048000", "10", "384000"});
            cpus.Add(new List<object>{"SSD 2", "1024000", "9", "192000"});
            cpus.Add(new List<object>{"SSD 2", "512000", "8", "96000"});
            cpus.Add(new List<object>{"SSD 2", "256000", "7", "48000"});
            cpus.Add(new List<object>{"SSD 2", "128000", "6", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "5", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "4", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "3", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "2", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "1", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "5", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "4", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "3", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "2", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "1", "300"});
            cpus.Add(new List<object>{"SSD", "2000", "0", "200"});
            cpus.Add(new List<object>{"HDD", "64000", "3", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "2", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "1", "1000"});
            cpus.Add(new List<object>{"HDD", "8000", "0", "500"});
        } else if (Global.Year == 10) {
            cpus.Add(new List<object>{"SSD 2", "4096000", "10", "768000"});
            cpus.Add(new List<object>{"SSD 2", "2048000", "9", "384000"});
            cpus.Add(new List<object>{"SSD 2", "1024000", "8", "192000"});
            cpus.Add(new List<object>{"SSD 2", "512000", "7", "96000"});
            cpus.Add(new List<object>{"SSD 2", "256000", "6", "48000"});
            cpus.Add(new List<object>{"SSD 2", "128000", "5", "24000"});
            cpus.Add(new List<object>{"SSD 2", "64000", "4", "12000"});
            cpus.Add(new List<object>{"SSD 2", "32000", "3", "6000"});
            cpus.Add(new List<object>{"SSD 2", "16000", "2", "3000"});
            cpus.Add(new List<object>{"SSD 2", "8000", "1", "900"});
            cpus.Add(new List<object>{"SSD 2", "4000", "0", "600"});
            cpus.Add(new List<object>{"SSD", "64000", "4", "8000"});
            cpus.Add(new List<object>{"SSD", "32000", "3", "4000"});
            cpus.Add(new List<object>{"SSD", "16000", "2", "2000"});
            cpus.Add(new List<object>{"SSD", "8000", "1", "1000"});
            cpus.Add(new List<object>{"SSD", "4000", "0", "300"});
            cpus.Add(new List<object>{"HDD", "64000", "2", "4000"});
            cpus.Add(new List<object>{"HDD", "32000", "1", "2000"});
            cpus.Add(new List<object>{"HDD", "16000", "0", "1000"});
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
