using Godot;
using System;
using System.Collections.Generic;

public class PhoneSoc : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneSocButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "10", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "9", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "8", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "7", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "9", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "8", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "7", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "6", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "8", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "7", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "6", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "5", "225"});

            cpus.Add(new List<object>{"Napdragon", "880", "7", "200"});
            cpus.Add(new List<object>{"Napdragon", "680", "6", "175"});
            cpus.Add(new List<object>{"Napdragon", "480", "5", "150"});
            cpus.Add(new List<object>{"Napdragon", "280", "4", "125"});

            cpus.Add(new List<object>{"Napdragon", "870", "6", "175"});
            cpus.Add(new List<object>{"Napdragon", "670", "5", "150"});
            cpus.Add(new List<object>{"Napdragon", "470", "4", "125"});
            cpus.Add(new List<object>{"Napdragon", "270", "3", "100"});

            cpus.Add(new List<object>{"Napdragon", "860", "5", "150"});
            cpus.Add(new List<object>{"Napdragon", "660", "4", "125"});
            cpus.Add(new List<object>{"Napdragon", "460", "3", "100"});
            cpus.Add(new List<object>{"Napdragon", "260", "2", "75"});

            cpus.Add(new List<object>{"Napdragon", "850", "4", "125"});
            cpus.Add(new List<object>{"Napdragon", "650", "3", "100"});
            cpus.Add(new List<object>{"Napdragon", "450", "2", "75"});
            cpus.Add(new List<object>{"Napdragon", "250", "1", "50"});

            cpus.Add(new List<object>{"Napdragon", "840", "3", "100"});
            cpus.Add(new List<object>{"Napdragon", "640", "2", "75"});
            cpus.Add(new List<object>{"Napdragon", "440", "1", "50"});
            cpus.Add(new List<object>{"Napdragon", "240", "0", "25"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "10", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "9", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "8", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "9", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "8", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "7", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "8", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "7", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "6", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "7", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "6", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "5", "140"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 5900", "6", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5700", "5", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5500", "4", "120"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 4900", "5", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4700", "4", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4500", "3", "100"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 3900", "4", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3700", "3", "100"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3500", "2", "80"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 2900", "3", "100"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 2700", "2", "80"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 2500", "1", "60"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 1900", "2", "80"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 1700", "1", "60"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 1500", "0", "40"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "10", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "9", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "8", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "7", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "9", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "8", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "7", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "6", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "8", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "7", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "6", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "5", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "7", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "6", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "5", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "4", "225"});

            cpus.Add(new List<object>{"Napdragon", "880", "6", "200"});
            cpus.Add(new List<object>{"Napdragon", "680", "5", "175"});
            cpus.Add(new List<object>{"Napdragon", "480", "4", "150"});
            cpus.Add(new List<object>{"Napdragon", "280", "3", "125"});

            cpus.Add(new List<object>{"Napdragon", "870", "5", "175"});
            cpus.Add(new List<object>{"Napdragon", "670", "4", "150"});
            cpus.Add(new List<object>{"Napdragon", "470", "3", "125"});
            cpus.Add(new List<object>{"Napdragon", "270", "2", "100"});

            cpus.Add(new List<object>{"Napdragon", "860", "4", "150"});
            cpus.Add(new List<object>{"Napdragon", "660", "3", "125"});
            cpus.Add(new List<object>{"Napdragon", "460", "2", "100"});
            cpus.Add(new List<object>{"Napdragon", "260", "1", "75"});

            cpus.Add(new List<object>{"Napdragon", "850", "3", "125"});
            cpus.Add(new List<object>{"Napdragon", "650", "2", "100"});
            cpus.Add(new List<object>{"Napdragon", "450", "1", "75"});
            cpus.Add(new List<object>{"Napdragon", "250", "0", "50"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "10", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "9", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "8", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "9", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "8", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "7", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "8", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "7", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "6", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "7", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "6", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "5", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "6", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "5", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "4", "140"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 5900", "5", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5700", "4", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5500", "3", "120"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 4900", "4", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4700", "3", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4500", "2", "100"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 3900", "3", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3700", "2", "100"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3500", "1", "80"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 2900", "2", "100"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 2700", "1", "80"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 2500", "0", "60"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "10", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "9", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "8", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "7", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "9", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "8", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "7", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "6", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "8", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "7", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "6", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "5", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "7", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "6", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "5", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "4", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "6", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "5", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "4", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "3", "225"});

            cpus.Add(new List<object>{"Napdragon", "880", "5", "200"});
            cpus.Add(new List<object>{"Napdragon", "680", "4", "175"});
            cpus.Add(new List<object>{"Napdragon", "480", "3", "150"});
            cpus.Add(new List<object>{"Napdragon", "280", "2", "125"});

            cpus.Add(new List<object>{"Napdragon", "870", "4", "175"});
            cpus.Add(new List<object>{"Napdragon", "670", "3", "150"});
            cpus.Add(new List<object>{"Napdragon", "470", "2", "125"});
            cpus.Add(new List<object>{"Napdragon", "270", "1", "100"});

            cpus.Add(new List<object>{"Napdragon", "860", "3", "150"});
            cpus.Add(new List<object>{"Napdragon", "660", "2", "125"});
            cpus.Add(new List<object>{"Napdragon", "460", "1", "100"});
            cpus.Add(new List<object>{"Napdragon", "260", "0", "75"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "10", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "9", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "8", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "9", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "8", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "7", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "8", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "7", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "6", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "7", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "6", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "5", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "6", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "5", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "4", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "5", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "4", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "3", "140"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 5900", "4", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5700", "3", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5500", "2", "120"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 4900", "3", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4700", "2", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4500", "1", "100"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 3900", "2", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3700", "1", "100"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 3500", "0", "80"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "10", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "9", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "8", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "7", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "9", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "8", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "7", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "6", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "8", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "7", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "6", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "5", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "7", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "6", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "5", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "4", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "6", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "5", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "4", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "3", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "5", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "4", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "3", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "2", "225"});

            cpus.Add(new List<object>{"Napdragon", "880", "4", "200"});
            cpus.Add(new List<object>{"Napdragon", "680", "3", "175"});
            cpus.Add(new List<object>{"Napdragon", "480", "2", "150"});
            cpus.Add(new List<object>{"Napdragon", "280", "1", "125"});

            cpus.Add(new List<object>{"Napdragon", "870", "3", "175"});
            cpus.Add(new List<object>{"Napdragon", "670", "2", "150"});
            cpus.Add(new List<object>{"Napdragon", "470", "1", "125"});
            cpus.Add(new List<object>{"Napdragon", "270", "0", "100"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "10", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "9", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "8", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "9", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "8", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "7", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "8", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "7", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "6", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "7", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "6", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "5", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "6", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "5", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "4", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "5", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "4", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "3", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "4", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "3", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "2", "140"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 5900", "3", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5700", "2", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5500", "1", "120"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 4900", "2", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4700", "1", "120"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 4500", "0", "100"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "10", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "9", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "8", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "7", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "9", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "8", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "7", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "6", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "8", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "7", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "6", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "5", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "7", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "6", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "5", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "4", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "6", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "5", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "4", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "3", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "5", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "4", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "3", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "2", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "4", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "3", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "2", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "1", "225"});

            cpus.Add(new List<object>{"Napdragon", "880", "3", "200"});
            cpus.Add(new List<object>{"Napdragon", "680", "2", "175"});
            cpus.Add(new List<object>{"Napdragon", "480", "1", "150"});
            cpus.Add(new List<object>{"Napdragon", "280", "0", "125"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "10", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "9", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "8", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "9", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "8", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "7", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "8", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "7", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "6", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "7", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "6", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "5", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "6", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "5", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "4", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "5", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "4", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "3", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "4", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "3", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "2", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "3", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "2", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "1", "140"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 5900", "2", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5700", "1", "140"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 5500", "0", "120"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"Napdragon", "8 Gen 7", "10", "475"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 7", "9", "450"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 7", "8", "425"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 7", "7", "400"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "9", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "8", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "7", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "6", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "8", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "7", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "6", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "5", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "7", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "6", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "5", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "4", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "6", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "5", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "4", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "3", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "5", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "4", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "3", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "2", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "4", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "3", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "2", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "1", "250"});

            cpus.Add(new List<object>{"Napdragon", "890", "3", "300"});
            cpus.Add(new List<object>{"Napdragon", "690", "2", "275"});
            cpus.Add(new List<object>{"Napdragon", "490", "1", "250"});
            cpus.Add(new List<object>{"Napdragon", "290", "0", "225"});

            cpus.Add(new List<object>{"MovieTek", "Universe 1900", "10", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1700", "9", "425"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1500", "8", "400"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "9", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "8", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "7", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "8", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "7", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "6", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "7", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "6", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "5", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "6", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "5", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "4", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "5", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "4", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "3", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "4", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "3", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "2", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "3", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "2", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "1", "160"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 6900", "2", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6700", "1", "160"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 6500", "0", "140"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 1", "10", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 1", "9", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 1", "8", "450"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 1", "7", "425"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 7", "9", "475"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 7", "8", "450"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 7", "7", "425"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 7", "6", "400"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "8", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "7", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "6", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "5", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "7", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "6", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "5", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "4", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "6", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "5", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "4", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "3", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "5", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "4", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "3", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "2", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "4", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "3", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "2", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "1", "275"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 1", "3", "325"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 1", "2", "300"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 1", "1", "275"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 1", "0", "250"});

            cpus.Add(new List<object>{"MovieTek", "Universe 2900", "10", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2700", "9", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2500", "8", "425"});

            cpus.Add(new List<object>{"MovieTek", "Universe 1900", "9", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1700", "8", "425"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1500", "7", "400"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "8", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "7", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "6", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "7", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "6", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "5", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "6", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "5", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "4", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "5", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "4", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "3", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "4", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "3", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "2", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "3", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "2", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "1", "180"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 7900", "2", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7700", "1", "180"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 7500", "0", "160"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 2", "10", "525"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 2", "9", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 2", "8", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 2", "7", "450"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 1", "9", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 1", "8", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 1", "7", "450"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 1", "6", "425"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 7", "8", "475"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 7", "7", "450"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 7", "6", "425"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 7", "5", "400"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "7", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "6", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "5", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "4", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "6", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "5", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "4", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "3", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "5", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "4", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "3", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "2", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "4", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "3", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "2", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "1", "300"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "3", "350"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 2", "2", "325"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 2", "1", "300"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 2", "0", "275"});

            cpus.Add(new List<object>{"MovieTek", "Universe 3900", "10", "500"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3700", "9", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3500", "8", "450"});

            cpus.Add(new List<object>{"MovieTek", "Universe 2900", "9", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2700", "8", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2500", "7", "425"});

            cpus.Add(new List<object>{"MovieTek", "Universe 1900", "8", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1700", "7", "425"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1500", "6", "400"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "7", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "6", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "5", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "6", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "5", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "4", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "5", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "4", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "3", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "4", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "3", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "2", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "3", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "2", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "1", "200"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 8900", "2", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8700", "1", "200"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 8500", "0", "180"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 3", "10", "550"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 3", "9", "525"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 3", "8", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 3", "7", "475"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 2", "9", "525"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 2", "8", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 2", "7", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 2", "6", "450"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 1", "8", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 1", "7", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 1", "6", "450"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 1", "5", "425"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 7", "7", "475"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 7", "6", "450"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 7", "5", "425"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 7", "4", "400"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "6", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "5", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "4", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "3", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "5", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "4", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "3", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "2", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "4", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "3", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "2", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "1", "325"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 3", "3", "375"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 3", "2", "350"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 3", "1", "325"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 3", "0", "300"});

            cpus.Add(new List<object>{"MovieTek", "Universe 4900", "10", "525"});
            cpus.Add(new List<object>{"MovieTek", "Universe 4700", "9", "500"});
            cpus.Add(new List<object>{"MovieTek", "Universe 4500", "8", "475"});

            cpus.Add(new List<object>{"MovieTek", "Universe 3900", "9", "500"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3700", "8", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3500", "7", "450"});

            cpus.Add(new List<object>{"MovieTek", "Universe 2900", "8", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2700", "7", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2500", "6", "425"});

            cpus.Add(new List<object>{"MovieTek", "Universe 1900", "7", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1700", "6", "425"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1500", "5", "400"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "6", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "5", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "4", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "5", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "4", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "3", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "4", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "3", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "2", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "3", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "2", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "1", "220"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 9900", "2", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9700", "1", "220"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 9500", "0", "200"});
        } else if (Global.Year == 10) {
            cpus.Add(new List<object>{"Napdragon", "Insomniadragon 8 Gen 1", "10", "575"});
            cpus.Add(new List<object>{"Napdragon", "Insomniadragon 6 Gen 1", "9", "550"});
            cpus.Add(new List<object>{"Napdragon", "Insomniadragon 4 Gen 1", "8", "525"});
            cpus.Add(new List<object>{"Napdragon", "Insomniadragon 2 Gen 1", "7", "500"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 3", "9", "550"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 3", "8", "525"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 3", "7", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 3", "6", "475"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 2", "8", "525"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 2", "7", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 2", "6", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 2", "5", "450"});

            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 8 Gen 1", "7", "500"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 6 Gen 1", "6", "475"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 4 Gen 1", "5", "450"});
            cpus.Add(new List<object>{"Napdragon", "Sleepdragon 2 Gen 1", "4", "425"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 7", "6", "475"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 7", "5", "450"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 7", "4", "425"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 7", "3", "400"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 6", "5", "450"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 6", "4", "425"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 6", "3", "400"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 6", "2", "375"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 5", "4", "425"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 5", "3", "400"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 5", "2", "375"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 5", "1", "350"});

            cpus.Add(new List<object>{"Napdragon", "8 Gen 4", "3", "400"});
            cpus.Add(new List<object>{"Napdragon", "6 Gen 4", "2", "375"});
            cpus.Add(new List<object>{"Napdragon", "4 Gen 4", "1", "350"});
            cpus.Add(new List<object>{"Napdragon", "2 Gen 4", "0", "325"});

            cpus.Add(new List<object>{"MovieTek", "Universe 5900", "10", "550"});
            cpus.Add(new List<object>{"MovieTek", "Universe 5700", "9", "525"});
            cpus.Add(new List<object>{"MovieTek", "Universe 5500", "8", "500"});

            cpus.Add(new List<object>{"MovieTek", "Universe 4900", "9", "525"});
            cpus.Add(new List<object>{"MovieTek", "Universe 4700", "8", "500"});
            cpus.Add(new List<object>{"MovieTek", "Universe 4500", "7", "475"});

            cpus.Add(new List<object>{"MovieTek", "Universe 3900", "8", "500"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3700", "7", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 3500", "6", "450"});

            cpus.Add(new List<object>{"MovieTek", "Universe 2900", "7", "475"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2700", "6", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 2500", "5", "425"});

            cpus.Add(new List<object>{"MovieTek", "Universe 1900", "6", "450"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1700", "5", "425"});
            cpus.Add(new List<object>{"MovieTek", "Universe 1500", "4", "400"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 13900", "5", "325"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13700", "4", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 13500", "3", "275"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 12900", "4", "300"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12700", "3", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 12500", "2", "260"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 11900", "3", "280"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11700", "2", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 11500", "1", "240"});

            cpus.Add(new List<object>{"MovieTek", "Dimension 10900", "2", "260"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10700", "1", "240"});
            cpus.Add(new List<object>{"MovieTek", "Dimension 10500", "0", "220"});
        }
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneSocButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
