using Godot;
using System;
using Newtonsoft.Json;

public class LoadGame : TextureButton {
    [Export]
    public string gameFile;
    public bool makeNewGame = false;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // Show company names
        // I wanted to do something smarter but it failed
        File file = new File();
        if (file.FileExists(gameFile)) {
            file.Open(gameFile, File.ModeFlags.Read);
            GetNode<Label>("Label").Text = JsonConvert.DeserializeObject<GameSave>(
                file.GetAsText()
            ).Name;
            file.Close();
        } else {
            makeNewGame = true;
        }
    }

    public void Click() {
        if (GetNodeOrNull("/root/Game") != null) {
            Node ben = GetNode("/root/Game");
            ben.QueueFree();
            ben.Name = "jkolskjhgjlkrjjhekol";
        }

        // was this save menu created by the new game dialog?
        if (Global.SavesMenuFromNewGame) {
            Savior.NewGame(gameFile, Global.NewGameSave);
            Global.NewGameSave = null;
            Global.SavesMenuFromNewGame = false;

            PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
            Game game_ = (Game)game.Instance();
            game_.Name = "Game";
            game_.Init(gameFile);
            GetTree().Root.AddChild(game_);
        
        } else {
            // load save or open the new game dialog
            if (!makeNewGame) {
                PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");

                #region reset a bunch of variables
                Global.WeekCounterThing = 0;
                Global.MonthlySales = 0;
                Global.DebtOno = 0;
                Global.PoliticsAlreadyAppeared = false;
                Global.ClimateChange = false;
                Global.Ac = false;
                Global.LowReputationScam = false;
                Global.UnlockMarketing1 = false;
                Global.ViralThingy = false;
                Global.NoEntiendoScam = false;
                Global.UnlockMarketing2 = false;
                Global.Lottery = false;
                Global.SpacezSatellites = false;
                Global.SpaceZLunarPissProject1 = false;
                Global.NoseLunarPissProject1 = false;
                Global.NoseLunarPissProject2 = false;
                Global.SpacezPissOnTheMoon = false;
                Global.NosePissOnTheMoon = false;
                Global.EpicGalaxiesHotel = false;
                Global.SpacezMarsLanding = false;
                Global.NoseMarsLanding = false;
                Global.EarthOrbitTrash = false;
                Global.EarthOrbitTrash2 = false;
                Global.UnlockSpaceColonization = false;
                Global.SpacezColonization = false;
                Global.NoseColonization = false;
                Global.YourMom1 = false;
                Global.BookMovie = true;
                Global.YourMom2 = false;
                Global.YourMom3 = false;
                Global.YourMom4 = false;
                Global.YourMom5 = false;
                Global.YourMom6 = false;
                Global.BadMedicalThing = true;
                Global.TheCureForCancer = false;
                Global.ReverseDisease = false;
                Global.Taxes1 = false;
                Global.Taxes2 = false;
                Global.Lab = false;
                Global.Ecs1 = false;
                Global.Ecs2 = false;
                Global.Ecs3 = false;
                Global.Ecs4 = false;
                Global.Ecs5 = false;
                Global.Ecs6 = false;
                Global.Ecs7 = false;
                Global.Ecs8 = false;
                Global.Ecs9 = false;
                Global.Ecs10 = false;
                Global.PrinceInEngland = false;
                Global.InfiniteCoffeeMachine = false;
                Global.InfiniteTeaMachine = false;
                Global.JamesPhotos = false;
                Global.WhiteRoom = false;
                Global.FloatingOffice = false;
                Global.FartSmells = false;
                Global.OfficeInsideOffice = false;
                Global.MoneyPrinter = false;
                Global.MoveToPaintopia = false;
                Global.Interview = false;
                Global.Offended = true;
                Global._4DMusic = false;
                Global.InterdimensionalMusic = false;
                Global.UniverseBreakingMusic = false;
                Global.MusicThatMakesNewMultiverses = false;
                Global.NoisesII = false;
                Global.MessagingAppDisease = true;
                Global.ApplianceSecurityBreach = true;
                Global.Boom = true;
                Global.EcsPhone1 = false;
                Global.EcsPhone2 = false;
                Global.EcsPhone3 = false;
                Global.EcsPhone4 = false;
                Global.EcsPhone5 = false;
                Global.EcsPhone6 = false;
                Global.EcsPhone7 = false;
                Global.EcsPhone8 = false;
                Global.EcsPhone9 = false;
                Global.EcsPhone10 = false;
                Global.NPTimesY1M6 = false;
                Global.NPTimesY1M8 = false;
                Global.NPTimesY1M12 = false;
                Global.NPTimesY2M6 = false;
                Global.NPTimesY2M12 = false;
                Global.NPTimesY3M6 = false;
                Global.NPTimesY3M12 = false;
                Global.NPTimesY4M6 = false;
                Global.NPTimesY4M12 = false;
                Global.NPTimesY5M6 = false;
                Global.NPTimesY5M12 = false;
                Global.NPTimesY6M6 = false;
                Global.NPTimesY6M12 = false;
                Global.NPTimesY7M6 = false;
                Global.NPTimesY7M7 = false;
                Global.NPTimesY7M12 = false;
                Global.NPTimesY8M6 = false;
                Global.NPTimesY8M12 = false;
                Global.NPTimesY9M4 = false;
                Global.NPTimesY9M6 = false;
                Global.NPTimesY9M8 = false;
                Global.NPTimesY9M9 = false;
                Global.NPTimesY9M12 = false;
                Global.NPTimesY10M1 = false;
                Global.NPTimesY10M6 = false;
                Global.NPTimesY10M8 = false;
                Global.NPTimesY10M12 = false;
                Global.TutorialImage = 0;
                Global.CookieDisc = false;
                Global.Smartphone2 = false;
                Global.RocketBoom = true;
                Global.Melonet = false;
                Global.MarsStockMarketCrash = false;
                Global.Meloncash = false;
                Global.NoseUranus = false;
                Global.NoseUranusTerraforming = false;
                Global.SpaceZPissRing = false;
                Global.MarsStockMarketCrashAgain = false;
                Global.SpaceZInvasion = false;
                Global.UranusLanding = false;
                Global.UranusState = false;
                Global.SpaceZPissRingFinish = false;
                Global.TimeSpeedMenu = false;
                Global.TimeSpeed = 1;
                Global.RipAllGameData = false;
                Global.Rooster = false;
                Global.Hola = false;
                Global.GameStation5Pro = false;
                Global.XcubeSeriesZ = false;
                Global.WeUs = false;
                Global.XcubeWrong = false;
                Global.GameStation6 = false;
                Global.Standing = false;
                Global.StandingRip = false;
                Global.WeAll = false;
                Global.YearOfTheGame = false;
                Global.DiscontinuedProduct = false;
                Global.DarkStoneInvestment = false;
                Global.DarkStonePay = false;
                Global.CompanyThatWillSoonExplode = "none :)";
                Global.Lawsuits = false;
                Global.HumanRelations = false;
                Global.TechStuff = false;
                Global.ForestCreation = false;
                Global.StoreGift = "nothing";
                Global.InvadedCountry = "sussy nation amongst us";
                Global.AiDomination = false;
                Global.GameFinished = false;
                #endregion

                Game game_ = (Game)game.Instance();
                game_.Name = "Game";
                game_.Init(gameFile);
                GetTree().Root.AddChild(game_);
            } else {
                PackedScene newGame_ = (PackedScene)ResourceLoader.Load("res://Scenes/NewCompany.tscn");
                Node2D newGame = (Node2D)newGame_.Instance();
                GetTree().Root.AddChild(newGame);
            }
        }

        // this button is inside a control node
        GetParent().GetParent().QueueFree();
    }
}
