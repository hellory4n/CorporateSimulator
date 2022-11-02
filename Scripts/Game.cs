using Godot;
using System;
using Newtonsoft.Json;

public class Game : Node2D {
    // we need to know where to save
    public void Init(string saveFile) {
        Global.SaveFile = saveFile;
    }

    public override void _Ready() {
        GD.Print("hi mom");

        /*Ball balls = new Ball();
        balls.Init("news", "GodotSpriteToTestTheButton");
        AddChild(balls);*/
        // settings
        Global.Settings = Savior.CreateFileStuff();
        // we don't want multiple music managers, that's a bit crinj
        if (Global.Settings.Music && GetNodeOrNull("/root/MusicManager") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/MusicManager.tscn");
            Node2D OK = (Node2D)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }

        // load things
        // TODO: load more things
        File file = new File(); // dictionary
        GameSave save = new GameSave();
        if (file.FileExists(Global.SaveFile)) {
            file.Open(Global.SaveFile, File.ModeFlags.Read);
            save = JsonConvert.DeserializeObject<GameSave>(
                file.GetAsText()
            );
            #region uhh
            Global.Money = save.Money;
            Global.Year = save.Year;
            Global.Month = save.Month;
            Global.Week = save.Week;
            Global.Reputation = save.Reputation;
            Global.CompanyName = save.Name;
            Global.CeoName = save.Ceo;
            Global.Industries = save.Industries;
            Global.ResearchPoints = save.ResearchPoints;
            Global.Investors = save.Investors;
            Global.InvestorsWant = save.InvestorsWant;
            Global.WeeksWithoutPayingInvestors = save.WeeksWithoutPayingInvestors;
            Global.InvestorFrequency = save.InvestorFrequency;
            #endregion
            file.Close();
        }
    }

    public override void _Process(float delta) {
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.F11))
            OS.WindowFullscreen = !OS.WindowFullscreen;

        Global.WeekCounterThing += 1f * delta;

        // calculate time stuff
        if (!Global.PausedTime) {
            if (Global.WeekCounterThing > 7.5) {
                Global.Week++;
                Global.WeekCounterThing = 0;
            }
            if (Global.Week > 4) {
                Global.Month++;
                Global.Week = 1;
            }
            if (Global.Month > 12) {
                Global.Year++;
                Global.Month = 1;
            }
        }

        base._Process(delta);
    }
}
