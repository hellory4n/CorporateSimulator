using Godot;
using System;
using System.Collections.Generic;

public class PhoneSoc : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneSocButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
        cpus.Add(new List<object>{"Napdragon", "8 Gen 2", "10", "380"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 9200", "10", "365"});
        cpus.Add(new List<object>{"Napdragon", "888", "9", "350"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 8200", "9", "335"});
        cpus.Add(new List<object>{"ByeSilicon", "Killin 9000", "8", "320"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 8000", "8", "305"});
        cpus.Add(new List<object>{"Napdragon", "870", "8", "290"});
        cpus.Add(new List<object>{"Napdragon", "865", "7", "275"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 1100", "7", "260"});
        cpus.Add(new List<object>{"ByeSilicon", "Killin 990 5G", "7", "245"});
        cpus.Add(new List<object>{"Napdragon", "778G Plus", "6", "230"});
        cpus.Add(new List<object>{"ByeSilicon", "990 4G", "6", "215"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 920", "6", "200"});
        cpus.Add(new List<object>{"Napdragon", "845", "5", "185"});
        cpus.Add(new List<object>{"MovieTek", "Dimension 810", "5", "170"});
        cpus.Add(new List<object>{"ByeSilicon", "Killin 810", "5", "155"});
        cpus.Add(new List<object>{"MovieTek", "Helium G96", "4", "140"});
        cpus.Add(new List<object>{"Napdragon", "835", "4", "125"});
        cpus.Add(new List<object>{"ByeSilicon", "Killin 970", "4", "110"});
        cpus.Add(new List<object>{"Multisoc", "Cheetah C618", "4", "95"});
        cpus.Add(new List<object>{"Multisoc", "Cheetah C616", "3", "80"});
        cpus.Add(new List<object>{"Napdragon", "662", "3", "65"});
        cpus.Add(new List<object>{"MovieTek", "Helium G70", "3", "50"});
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
