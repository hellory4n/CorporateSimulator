using Godot;
using System;
using System.Collections.Generic;

public class PhoneSize : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneSizeButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"7", "10", "50"});
            cpus.Add(new List<object>{"6.5", "9", "45"});
            cpus.Add(new List<object>{"6", "8", "40"});
            cpus.Add(new List<object>{"5.5", "7", "35"});
            cpus.Add(new List<object>{"5", "6", "30"});
            cpus.Add(new List<object>{"4.5", "5", "25"});
            cpus.Add(new List<object>{"4", "4", "20"});
            cpus.Add(new List<object>{"3.5", "3", "15"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"7.5", "10", "55"});
            cpus.Add(new List<object>{"7", "9", "50"});
            cpus.Add(new List<object>{"6.5", "8", "45"});
            cpus.Add(new List<object>{"6", "7", "40"});
            cpus.Add(new List<object>{"5.5", "6", "35"});
            cpus.Add(new List<object>{"5", "5", "30"});
            cpus.Add(new List<object>{"4.5", "4", "25"});
            cpus.Add(new List<object>{"4", "3", "20"});
            cpus.Add(new List<object>{"3.5", "2", "15"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"8", "10", "60"});
            cpus.Add(new List<object>{"7.5", "9", "55"});
            cpus.Add(new List<object>{"7", "8", "50"});
            cpus.Add(new List<object>{"6.5", "7", "45"});
            cpus.Add(new List<object>{"6", "6", "40"});
            cpus.Add(new List<object>{"5.5", "5", "35"});
            cpus.Add(new List<object>{"5", "4", "30"});
            cpus.Add(new List<object>{"4.5", "3", "25"});
            cpus.Add(new List<object>{"4", "2", "20"});
            cpus.Add(new List<object>{"3.5", "1", "15"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"8.5", "10", "65"});
            cpus.Add(new List<object>{"8", "9", "60"});
            cpus.Add(new List<object>{"7.5", "8", "55"});
            cpus.Add(new List<object>{"7", "7", "50"});
            cpus.Add(new List<object>{"6.5", "6", "45"});
            cpus.Add(new List<object>{"6", "5", "40"});
            cpus.Add(new List<object>{"5.5", "4", "35"});
            cpus.Add(new List<object>{"5", "3", "30"});
            cpus.Add(new List<object>{"4.5", "2", "25"});
            cpus.Add(new List<object>{"4", "1", "20"});
            cpus.Add(new List<object>{"3.5", "0", "15"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"9", "10", "70"});
            cpus.Add(new List<object>{"8.5", "9", "65"});
            cpus.Add(new List<object>{"8", "8", "60"});
            cpus.Add(new List<object>{"7.5", "7", "55"});
            cpus.Add(new List<object>{"7", "6", "50"});
            cpus.Add(new List<object>{"6.5", "5", "45"});
            cpus.Add(new List<object>{"6", "4", "40"});
            cpus.Add(new List<object>{"5.5", "3", "35"});
            cpus.Add(new List<object>{"5", "2", "30"});
            cpus.Add(new List<object>{"4.5", "1", "25"});
            cpus.Add(new List<object>{"4", "0", "20"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"9.5", "10", "75"});
            cpus.Add(new List<object>{"9", "9", "70"});
            cpus.Add(new List<object>{"8.5", "8", "65"});
            cpus.Add(new List<object>{"8", "7", "60"});
            cpus.Add(new List<object>{"7.5", "6", "55"});
            cpus.Add(new List<object>{"7", "5", "50"});
            cpus.Add(new List<object>{"6.5", "4", "45"});
            cpus.Add(new List<object>{"6", "3", "40"});
            cpus.Add(new List<object>{"5.5", "2", "35"});
            cpus.Add(new List<object>{"5", "1", "30"});
            cpus.Add(new List<object>{"4.5", "0", "25"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"10", "10", "80"});
            cpus.Add(new List<object>{"9.5", "9", "75"});
            cpus.Add(new List<object>{"9", "8", "70"});
            cpus.Add(new List<object>{"8.5", "7", "65"});
            cpus.Add(new List<object>{"8", "6", "60"});
            cpus.Add(new List<object>{"7.5", "5", "55"});
            cpus.Add(new List<object>{"7", "4", "50"});
            cpus.Add(new List<object>{"6.5", "3", "45"});
            cpus.Add(new List<object>{"6", "2", "40"});
            cpus.Add(new List<object>{"5.5", "1", "35"});
            cpus.Add(new List<object>{"5", "0", "30"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"10.5", "10", "85"});
            cpus.Add(new List<object>{"10", "9", "80"});
            cpus.Add(new List<object>{"9.5", "8", "75"});
            cpus.Add(new List<object>{"9", "7", "70"});
            cpus.Add(new List<object>{"8.5", "6", "65"});
            cpus.Add(new List<object>{"8", "5", "60"});
            cpus.Add(new List<object>{"7.5", "4", "55"});
            cpus.Add(new List<object>{"7", "3", "50"});
            cpus.Add(new List<object>{"6.5", "2", "45"});
            cpus.Add(new List<object>{"6", "1", "40"});
            cpus.Add(new List<object>{"5.5", "0", "35"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"11", "10", "90"});
            cpus.Add(new List<object>{"10.5", "9", "85"});
            cpus.Add(new List<object>{"10", "8", "80"});
            cpus.Add(new List<object>{"9.5", "7", "75"});
            cpus.Add(new List<object>{"9", "6", "70"});
            cpus.Add(new List<object>{"8.5", "5", "65"});
            cpus.Add(new List<object>{"8", "4", "60"});
            cpus.Add(new List<object>{"7.5", "3", "55"});
            cpus.Add(new List<object>{"7", "2", "50"});
            cpus.Add(new List<object>{"6.5", "1", "45"});
            cpus.Add(new List<object>{"6", "0", "40"});
        } else if (Global.Year > 9) {
            cpus.Add(new List<object>{"11.5", "10", "95"});
            cpus.Add(new List<object>{"11", "9", "90"});
            cpus.Add(new List<object>{"10.5", "8", "85"});
            cpus.Add(new List<object>{"10", "7", "80"});
            cpus.Add(new List<object>{"9.5", "6", "75"});
            cpus.Add(new List<object>{"9", "5", "70"});
            cpus.Add(new List<object>{"8.5", "4", "65"});
            cpus.Add(new List<object>{"8", "3", "60"});
            cpus.Add(new List<object>{"7.5", "2", "55"});
            cpus.Add(new List<object>{"7", "1", "50"});
            cpus.Add(new List<object>{"6.5", "0", "45"});
        }
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
