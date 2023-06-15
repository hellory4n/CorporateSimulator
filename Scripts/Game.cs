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

        // we also don't want multiple autosaves
        if (Global.Settings.Autosave && GetNodeOrNull("/root/Autosave") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Autosave.tscn");
            Timer OK = (Timer)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }

        if (GetNodeOrNull("/root/Events") == null) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Events.tscn");
            Node2D OK = (Node2D)yes.Instance();
            // if i do it immediately godot will complain that it's busy setting up stuff
            GetTree().Root.CallDeferred("add_child", OK);
        }

        // load things
        // TODO: load more things
        File file = new File(); // if you haven't noticed this is a file
        GameSave save = new GameSave();
        if (file.FileExists(Global.SaveFile)) {
            file.Open(Global.SaveFile, File.ModeFlags.ReadWrite);
            // is this an old save? if so, make it new!
            VeryOldGameSave painsave = JsonConvert.DeserializeObject<VeryOldGameSave>(
                file.GetAsText()
            );
            if (painsave.Version == "0.8") {
                painsave.Version = "0.9";
                // we don't want the game to keep converting the save
                file.StoreString(JsonConvert.SerializeObject(painsave));
                string oldSaveStuff = file.GetAsText();
                oldSaveStuff = oldSaveStuff.Substring(0, oldSaveStuff.Length-1);
                // i hope you have an ultraveryreallytotallywidescreen display
                oldSaveStuff += ",\"Purchased\":[{\"Name\":\"Bagged Air\",\"Amount\":0,\"Price\":0},{\"Name\":\"Squaritos\",\"Amount\":0,\"Price\":0},{\"Name\":\"Washing Machine\",\"Amount\":0,\"Price\":0},{\"Name\":\"Remote-controlled Grill\",\"Amount\":0,\"Price\":0},{\"Name\":\"A Thing\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 15\",\"Amount\":0,\"Price\":0},{\"Name\":\"Innovative T-Shirt\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiToothbrush\",\"Amount\":0,\"Price\":0},{\"Name\":\"ELECTRIC GRID KILLER 6900\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Barbecue\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Cheese\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 16\",\"Amount\":0,\"Price\":0},{\"Name\":\"Webdoor\",\"Amount\":0,\"Price\":0},{\"Name\":\"Flying House\",\"Amount\":0,\"Price\":0},{\"Name\":\"WebToasts\",\"Amount\":0,\"Price\":0},{\"Name\":\"Milk\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 17\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bag with rocks\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Air\",\"Amount\":0,\"Price\":0},{\"Name\":\"webtoasts²\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 18\",\"Amount\":0,\"Price\":0},{\"Name\":\"Remote controller for a horse\",\"Amount\":0,\"Price\":0},{\"Name\":\"Cheese\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Fart\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Spicy\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 19\",\"Amount\":0,\"Price\":0},{\"Name\":\"Orange Juice\",\"Amount\":0,\"Price\":0},{\"Name\":\"webtoasts³\",\"Amount\":0,\"Price\":0},{\"Name\":\"Random number book\",\"Amount\":0,\"Price\":0},{\"Name\":\"Choccy milk\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 20\",\"Amount\":0,\"Price\":0},{\"Name\":\"webtoasts⁴\",\"Amount\":0,\"Price\":0},{\"Name\":\"Skepticism Antivirus\",\"Amount\":0,\"Price\":0},{\"Name\":\"Cookie\",\"Amount\":0,\"Price\":0},{\"Name\":\"Money\",\"Amount\":0,\"Price\":0},{\"Name\":\"Air without a bag\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 21\",\"Amount\":0,\"Price\":0},{\"Name\":\"webpaper\",\"Amount\":0,\"Price\":0},{\"Name\":\"Wireless Charger\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bag surrounded by air in a bag\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 22\",\"Amount\":0,\"Price\":0},{\"Name\":\"webpaper²\",\"Amount\":0,\"Price\":0},{\"Name\":\"Toilet Paper\",\"Amount\":0,\"Price\":0},{\"Name\":\"A lot of money\",\"Amount\":0,\"Price\":0},{\"Name\":\"Holy Cheese\",\"Amount\":0,\"Price\":0},{\"Name\":\"hiPhone 23\",\"Amount\":0,\"Price\":0},{\"Name\":\"Smiling rock\",\"Amount\":0,\"Price\":0},{\"Name\":\"Infinite potatos\",\"Amount\":0,\"Price\":0},{\"Name\":\"Golden tophat\",\"Amount\":0,\"Price\":0},{\"Name\":\"Bagged Air Onion\",\"Amount\":0,\"Price\":0}],\"Advisor\":\"no one\",\"MoneyHistory\":[]}";
                file.Seek(0);
                file.StoreString(oldSaveStuff);
            }
            
            // now we load it again but as a new save
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
            Global.MarketingBudget = save.MarketingBudget;
            Global.InvestorsInvested = save.InvestorsInvested;
            Global.Investments = save.Investments;
            Global.AvailableInvestments = save.AvailableInvestments;
            Global.Version = save.Version;
            Global.Purchased = save.Purchased;
            Global.Advisor = save.Advisor;
            Global.MoneyHistory = save.MoneyHistory.ToList();
            Global.LabUnlocked = save.LabUnlocked;
            Global.LabResearch = save.LabResearch.ToList();
            Global.LabBudget = save.LabBudget;
            Global.LabThingsToSpend = save.LabThingsToSpend;
            Global.LabCurrentProject = save.LabCurrentProject;
            Global.LabTotalCost = save.LabTotalCost;
            Global.CustomOS = save.CustomOS;
            Global.CustomChip = save.CustomChip;
            Global.CustomConsole = save.CustomConsole;
            Global.GovernmentUnlocked = save.GovernmentUnlocked;
            Global.CountryName = save.CountryName;
            Global.UnitedStates = save.UnitedStates;
            Global.China = save.China;
            Global.Army = save.Army;
            Global.Navy = save.Navy;
            Global.AirForce = save.AirForce;
            Global.Invaded = save.Invaded;
            #endregion
            file.Close();
            // developing thing
            if (Global.Developing != null) {
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
                Label OK = (Label)yes.Instance();
                OK.RectPosition = new Vector2(-25, 286);
                GetTree().Root.AddChild(OK);
            }

            // so we only get the debt dialog once
            if (Global.Money < 0)
                Global.DebtOno = 2;
            // yeah
            if (Global.Money > 10000000)
                Global.UnlockMarketing1 = true;
            if (Global.Money > 50000000)
                Global.UnlockMarketing2 = true;
            if (Global.Money > 1000000)
                Global.Taxes1 = true;
            if (Global.Money > 100000000)
                Global.Taxes2 = true;
            if (Global.Money > 1000000000)
                Global.Lab = true;
            if (Global.Invaded.Count == 157)
                Global.GameFinished = true;
            
            // do we show the tutorial
            File aFile = new File(); // this is a string i think
            if (!aFile.FileExists("user://first_time")) {
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Tutorial.tscn");
                Node2D OK = (Node2D)yes.Instance();
                GetTree().Root.AddChild(OK);
                Global.PausedTime = true;
            }
        }
    }

    public override void _Process(float delta) {
        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.F11))
            OS.WindowFullscreen = !OS.WindowFullscreen;

        if (Input.IsPhysicalKeyPressed((int)Godot.KeyList.Control) &&
        Input.IsPhysicalKeyPressed((int)Godot.KeyList.S))
            Savior.SaveGame(Global.SaveFile);

        Global.WeekCounterThing += 1f * delta;

        // calculate time stuff
        if (!Global.PausedTime) {
            if (Global.WeekCounterThing > (15/Global.TimeSpeed)) {
                Global.Week++;
                Global.WeeksWithoutPayingInvestors++;
                Global.WeekCounterThing = 0;
                Global.Investors += Global.MarketingBudget/1000;
                // yes
                Global.PoliticsAlreadyAppeared = false;

                // george j. miller advisor
                if (Global.Advisor == "george j. miller") {
                    Global.Money -= 100000;
                    Global.Reputation -= 1;
                    Global.Investors -= 100;
                    Global.Taxes += 100;
                }
                // john tiffany james advisor
                if (Global.Advisor == "john tiffany james") {
                    Global.Money += 250000;
                }

                // epic lab thingies
                if (Global.LabCurrentProject != "nothing") {
                    Global.Money -= (int)Global.LabBudget/4;
                    Global.LabThingsToSpend -= (int)Global.LabBudget/4;
                    if (Global.LabThingsToSpend < 0) {
                        Global.LabResearch.Add(Global.LabCurrentProject);
                        // unlock the government
                        if (Global.LabCurrentProject == "make a government") {
                            Global.GovernmentUnlocked = true;
                            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
                            Ball OK = (Ball)yes.Instance();
                            OK.Init("unlock", "Unlock/Government");
                            OK.ZIndex = 100;
                            GetTree().Root.AddChild(OK);
                        } else {
                            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
                            Ball OK = (Ball)yes.Instance();
                            OK.Init("unlock", "LabFinishedResearch");
                            OK.ZIndex = 100;
                            GetTree().Root.AddChild(OK);
                        }
                        Global.LabCurrentProject = "nothing";
                    }
                }
            }
            if (Global.Week > 4) {
                // chris cool advisor
                if (Global.Advisor == "chris cool") {
                    Global.Reputation += 5;
                }

                // calculate the salaries
                foreach (var employee in Global.Employees) {
                    Global.Salaries += employee.Salary;
                }
                // epic advisor salaries
                switch (Global.Advisor) {
                    case "george j. miller": Global.Salaries += 100000; break;
                    case "john tiffany james": Global.Salaries += 500000; break;
                    case "justin case": Global.Salaries += 500000; break;
                    case "mark etin": Global.Salaries += 1000000; break;
                    case "amon lee hughman": Global.Salaries += 1000000; break;
                    case "linus droppinson": Global.Salaries += 1000000; break;
                    case "treeresa bush": Global.Salaries += 1000000; break;
                    case "chris cool": Global.Salaries += 5000000; break;
                    case "robert elstem": Global.Salaries += 5000000; break;
                    case "william buffet": Global.Salaries += 5000000; break;
                }
                Global.Money -= Global.Salaries;

                // trade agreeements
                if (Global.UnitedStates.TradeAgreement) {
                    Global.Money += 1000000000;
                }
                if (Global.China.TradeAgreement) {
                    Global.Money += 1000000000;
                }

                // the more countries, the more money
                Global.Money += Global.Invaded.Count*5000000000;

                // do the monthly money thing
                if (Global.LabUnlocked) {
                    Label monthlyMoneyThing = GetNode<Label>("MonthlyMoneyStuff");
                    monthlyMoneyThing.Text = $"Y{Global.Year} M{Global.Month}:\n" +
                        $"-${String.Format("{0:n0}", Global.Taxes)} taxes\n" +
                        $"-${String.Format("{0:n0}", Global.Salaries)} salaries\n" + 
                        $"-${String.Format("{0:n0}", Global.MarketingBudget+Global.LabBudget)} marketing and lab\n" +
                        $"+${String.Format("{0:n0}", Global.InvestorPayment)} from investors\n" +
                        $"+${String.Format("{0:n0}", Global.MonthlySales)} product sales";
                } else {
                    Label monthlyMoneyThing = GetNode<Label>("MonthlyMoneyStuff");
                    monthlyMoneyThing.Text = $"Y{Global.Year} M{Global.Month}:\n" +
                        $"-${String.Format("{0:n0}", Global.Taxes)} taxes\n" +
                        $"-${String.Format("{0:n0}", Global.Salaries)} salaries\n" + 
                        $"-${String.Format("{0:n0}", Global.MarketingBudget)} marketing\n" +
                        $"+${String.Format("{0:n0}", Global.InvestorPayment)} from investors\n" +
                        $"+${String.Format("{0:n0}", Global.MonthlySales)} product sales";
                }

                Global.Salaries = 0;
                Global.MonthlySales = 0;
                
                Global.Month++;
                Global.Money += Global.InvestorPayment;
                Global.Money -= Global.Taxes; // taxes :(
                Global.Money -= Global.MarketingBudget; // go bankrupt speedrun NOTE FROM THE FUTURE: mues
                

                Global.Week = 1;

                // william buffet advisor
                if (Global.Advisor == "william buffet") {
                    Global.Money -= Global.InvestorsWant;
                    Global.WeeksWithoutPayingInvestors = 0;
                    Global.InvestorSusometer = 0;
                    Global.Investors += (int)Global.Investors/10;
                }

                // statistics
                Global.MoneyHistory.Add(Global.Money);

                // stock market prices
                for (int i = 0; i < Global.AvailableInvestments.Length; i++) {
                    Random suffering = new Random();
                    // are we in a recession?
                    if ((Global.Year==1 && Global.Month==11) || (Global.Year==7 && Global.Month==3) ||
                    (Global.Year==9 && Global.Month==3) || (Global.Year==10 && Global.Month==1)) {
                        Global.AvailableInvestments[i].Price /= suffering.Next(2, 5);
                    } else {
                        Global.AvailableInvestments[i].Price += suffering.Next(-20, 50);
                    }
                }
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
            if (Global.InvestorTimeCounterThing > Global.InvestorFrequency*(15/Global.TimeSpeed)) {
                Global.Investors++;
                Global.InvestorTimeCounterThing = 0;
            }
            if (Global.InvestorSusometerCounterThingyUhh > (60/Global.TimeSpeed)) { // 2 months
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
        if (Global.Investors < 0)
            Global.Investors = 0;
        if (Global.UnitedStates.Friendship > 100)
            Global.UnitedStates.Friendship = 100;
        if (Global.UnitedStates.Friendship < 0)
            Global.UnitedStates.Friendship = 0;
        if (Global.China.Friendship > 100)
            Global.China.Friendship = 100;
        if (Global.China.Friendship < 0)
            Global.China.Friendship = 0;
        
        // pause time?
        if (GetNodeOrNull<Node2D>("/root/PauseMenu") != null || GetNodeOrNull<Node2D>("/root/ActionCenter")
        != null || GetNodeOrNull<Node2D>("/root/CreditsThing") != null ||
        GetNodeOrNull<Node2D>("/root/PauseThingy") != null || GetNodeOrNull<Node2D>("/root/Tutorial") != null ||
        GetNodeOrNull<Node2D>("/root/Settings") != null || GetNodeOrNull<Node2D>("/root/Bankrupt") != null ||
        GetNodeOrNull<Node2D>("/root/Lab") != null || GetNodeOrNull<Node2D>("/root/Government") != null ||
        GetNodeOrNull<Node2D>("/root/Achievements") != null)
            Global.PausedTime = true;
        else
            Global.PausedTime = false;

        base._Process(delta);
    }
}
