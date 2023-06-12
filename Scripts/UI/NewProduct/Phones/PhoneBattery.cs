using Godot;
using System;
using System.Collections.Generic;

public class PhoneBattery : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneBatteryButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        if (Global.Year == 1) {
            cpus.Add(new List<object>{"24", "10", "30"});
            cpus.Add(new List<object>{"18", "9", "25"});
            cpus.Add(new List<object>{"12", "8", "20"});
            cpus.Add(new List<object>{"8", "7", "15"});
            cpus.Add(new List<object>{"4", "6", "10"});
            cpus.Add(new List<object>{"2", "5", "5"});
            cpus.Add(new List<object>{"1", "4", "2"});
        } else if (Global.Year == 2) {
            cpus.Add(new List<object>{"30", "10", "35"});
            cpus.Add(new List<object>{"24", "9", "30"});
            cpus.Add(new List<object>{"18", "8", "25"});
            cpus.Add(new List<object>{"12", "7", "20"});
            cpus.Add(new List<object>{"8", "6", "15"});
            cpus.Add(new List<object>{"4", "5", "10"});
            cpus.Add(new List<object>{"2", "4", "5"});
            cpus.Add(new List<object>{"1", "3", "2"});
        } else if (Global.Year == 3) {
            cpus.Add(new List<object>{"36", "10", "40"});
            cpus.Add(new List<object>{"30", "9", "35"});
            cpus.Add(new List<object>{"24", "8", "30"});
            cpus.Add(new List<object>{"18", "7", "25"});
            cpus.Add(new List<object>{"12", "6", "20"});
            cpus.Add(new List<object>{"8", "5", "15"});
            cpus.Add(new List<object>{"4", "4", "10"});
            cpus.Add(new List<object>{"2", "3", "5"});
            cpus.Add(new List<object>{"1", "2", "2"});
        } else if (Global.Year == 4) {
            cpus.Add(new List<object>{"42", "10", "45"});
            cpus.Add(new List<object>{"36", "9", "40"});
            cpus.Add(new List<object>{"30", "8", "35"});
            cpus.Add(new List<object>{"24", "7", "30"});
            cpus.Add(new List<object>{"18", "6", "25"});
            cpus.Add(new List<object>{"12", "5", "20"});
            cpus.Add(new List<object>{"8", "4", "15"});
            cpus.Add(new List<object>{"4", "3", "10"});
            cpus.Add(new List<object>{"2", "2", "5"});
            cpus.Add(new List<object>{"1", "1", "2"});
        } else if (Global.Year == 5) {
            cpus.Add(new List<object>{"48", "10", "50"});
            cpus.Add(new List<object>{"42", "9", "45"});
            cpus.Add(new List<object>{"36", "8", "40"});
            cpus.Add(new List<object>{"30", "7", "35"});
            cpus.Add(new List<object>{"24", "6", "30"});
            cpus.Add(new List<object>{"18", "5", "25"});
            cpus.Add(new List<object>{"12", "4", "20"});
            cpus.Add(new List<object>{"8", "3", "15"});
            cpus.Add(new List<object>{"4", "2", "10"});
            cpus.Add(new List<object>{"2", "1", "5"});
            cpus.Add(new List<object>{"1", "0", "2"});
        } else if (Global.Year == 6) {
            cpus.Add(new List<object>{"54", "10", "55"});
            cpus.Add(new List<object>{"48", "9", "50"});
            cpus.Add(new List<object>{"42", "8", "45"});
            cpus.Add(new List<object>{"36", "7", "40"});
            cpus.Add(new List<object>{"30", "6", "35"});
            cpus.Add(new List<object>{"24", "5", "30"});
            cpus.Add(new List<object>{"18", "4", "25"});
            cpus.Add(new List<object>{"12", "3", "20"});
            cpus.Add(new List<object>{"8", "2", "15"});
            cpus.Add(new List<object>{"4", "1", "10"});
            cpus.Add(new List<object>{"2", "0", "5"});
        } else if (Global.Year == 7) {
            cpus.Add(new List<object>{"60", "10", "60"});
            cpus.Add(new List<object>{"54", "9", "55"});
            cpus.Add(new List<object>{"48", "8", "50"});
            cpus.Add(new List<object>{"42", "7", "45"});
            cpus.Add(new List<object>{"36", "6", "40"});
            cpus.Add(new List<object>{"30", "5", "35"});
            cpus.Add(new List<object>{"24", "4", "30"});
            cpus.Add(new List<object>{"18", "3", "25"});
            cpus.Add(new List<object>{"12", "2", "20"});
            cpus.Add(new List<object>{"8", "1", "15"});
            cpus.Add(new List<object>{"4", "0", "10"});
        } else if (Global.Year == 8) {
            cpus.Add(new List<object>{"66", "10", "65"});
            cpus.Add(new List<object>{"60", "9", "60"});
            cpus.Add(new List<object>{"54", "8", "55"});
            cpus.Add(new List<object>{"48", "7", "50"});
            cpus.Add(new List<object>{"42", "6", "45"});
            cpus.Add(new List<object>{"36", "5", "40"});
            cpus.Add(new List<object>{"30", "4", "35"});
            cpus.Add(new List<object>{"24", "3", "30"});
            cpus.Add(new List<object>{"18", "2", "25"});
            cpus.Add(new List<object>{"12", "1", "20"});
            cpus.Add(new List<object>{"8", "0", "15"});
        } else if (Global.Year == 9) {
            cpus.Add(new List<object>{"72", "10", "70"});
            cpus.Add(new List<object>{"66", "9", "65"});
            cpus.Add(new List<object>{"60", "8", "60"});
            cpus.Add(new List<object>{"54", "7", "55"});
            cpus.Add(new List<object>{"48", "6", "50"});
            cpus.Add(new List<object>{"42", "5", "45"});
            cpus.Add(new List<object>{"36", "4", "40"});
            cpus.Add(new List<object>{"30", "3", "35"});
            cpus.Add(new List<object>{"24", "2", "30"});
            cpus.Add(new List<object>{"18", "1", "25"});
            cpus.Add(new List<object>{"12", "0", "20"});
        } else if (Global.Year > 9) {
            cpus.Add(new List<object>{"78", "10", "75"});
            cpus.Add(new List<object>{"72", "9", "70"});
            cpus.Add(new List<object>{"66", "8", "65"});
            cpus.Add(new List<object>{"60", "7", "60"});
            cpus.Add(new List<object>{"54", "6", "55"});
            cpus.Add(new List<object>{"48", "5", "50"});
            cpus.Add(new List<object>{"42", "4", "45"});
            cpus.Add(new List<object>{"36", "3", "40"});
            cpus.Add(new List<object>{"30", "2", "35"});
            cpus.Add(new List<object>{"24", "1", "30"});
            cpus.Add(new List<object>{"18", "0", "25"});
        }
        #endregion
        
        // make epic buttons
        foreach (var item in cpus) {
            var OK = (PhoneBatteryButton)yes.Instance();
            OK.Init(item);
            AddChild(OK);
        }

        base._Ready();
    }
}
