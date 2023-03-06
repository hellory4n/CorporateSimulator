using Godot;
using System;
using System.Collections.Generic;

public class PhoneSoc : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/PhoneSocButton.tscn");
        List<List<object>> cpus = new List<List<object>>();
        #region ohio 30 day trial
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
