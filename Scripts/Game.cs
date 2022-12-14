using Godot;
using System;
using Newtonsoft.Json;
using System.Linq;

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
            Global.WeeksWithoutPayingInvestors = save.WeeksWithoutPayingInvestors;
            Global.InvestorFrequency = save.InvestorFrequency;
            Global.InvestorSusometer = save.InvestorSusometer;
            Global.Employees = save.Employees.ToList();
            Global.Taxes = save.Taxes;
            Global.UnlockedResearch = save.UnlockedResearch;
            Global.Researched = save.Researched;
            Global.Products = save.Products;
            Global.Developing = save.Developing;
            Global.DevelopingProgress = save.DevelopingProgress;
            Global.DevelopingName = save.DevelopingName;
            #endregion
            file.Close();
            // developing thing
            if (Global.Developing != null) {
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
                Label OK = (Label)yes.Instance();
                OK.RectPosition = new Vector2(-25, 286);
                GetTree().Root.AddChild(OK);
                
            }
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
                Global.WeeksWithoutPayingInvestors++;
                Global.WeekCounterThing = 0;
            }
            if (Global.Week > 4) {
                Global.Month++;
                Global.Money += Global.InvestorPayment;
                Global.Money -= Global.Taxes; // taxes :(
                Global.Week = 1;

                // calculate the salaries
                foreach (var employee in Global.Employees) {
                    Global.Salaries += employee.Salary;
                }
                Global.Money -= Global.Salaries;

                // do the monthly money thing
                Label monthlyMoneyThing = GetNode<Label>("MonthlyMoneyStuff");
                monthlyMoneyThing.Text = $"-${String.Format("{0:n0}", Global.Taxes)} taxes\n" +
                    $"-${String.Format("{0:n0}", Global.Salaries)} salaries\n" + 
                    $"+${String.Format("{0:n0}", Global.InvestorPayment)} from investors";
                
                Global.Salaries = 0;
            }
            if (Global.Month > 12) {
                Global.Year++;
                Global.Month = 1;
            }
        }

        // calculate investor stuff
        Global.InvestorTimeCounterThing += 1f * delta;
        Global.InvestorSusometerCounterThingyUhh += 1f * delta;
        // new investors
        if (!Global.PausedTime) {
            if (Global.InvestorTimeCounterThing > Global.InvestorFrequency*7.5) {
                Global.Investors++;
                Global.InvestorTimeCounterThing = 0;
            }
            if (Global.InvestorSusometerCounterThingyUhh > 60) { // 2 months
                Global.InvestorSusometer++;
                Global.Investors -= Global.InvestorSusometer;
                Global.Reputation -= 1;
                Global.InvestorSusometerCounterThingyUhh = 0;
            }
        }
        // calculate boring investor variables
        Global.InvestorPayment = Global.Investors*Global.Reputation*2;
        Global.InvestorsWant = (int)Math.Round((double)Global.InvestorPayment/4);

        // avoid interesting occasions
        if (Global.Reputation > 100)
            Global.Reputation = 100;
        // TODO: show a game over screen when the reputation is 0
        if (Global.Investors < 0)
            Global.Investors = 0;
        
        // pause time?
        if (GetNodeOrNull<Node2D>("/root/PauseMenu") != null || GetNodeOrNull<Node2D>("/root/ActionCenter")
        != null || GetNodeOrNull<Node2D>("/root/CreditsThing") != null)
            Global.PausedTime = true;
        else
            Global.PausedTime = false;

        base._Process(delta);
    }
}
