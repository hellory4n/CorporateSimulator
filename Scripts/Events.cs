using Godot;
using System;

public class Events : Node2D {
    Random random = new Random();

    public override void _Process(float delta) {
        #region Sales
        // we can't sell void
        if (Global.Products.Count > 0) {
            dynamic garbage = Global.Products[Global.Products.Count-1]; // hope this doesn't explode
            int price = 69420;
            double saleRate = 80;

            // garbage price
            if (garbage is ComputerProduct) {
                ComputerProduct shjksj = (ComputerProduct)garbage;
                price = shjksj.Price;
            } else if (garbage is TvProduct) {
                TvProduct hjskosp = (TvProduct)garbage;
                price = hjskosp.Ads*10;
            } else if (garbage is AppProduct) {
                AppProduct jskiops = (AppProduct)garbage;
                price = jskiops.Algorithm*10;
            } else if (garbage is PhoneProduct) {
                PhoneProduct hjsksjk = (PhoneProduct)garbage;
                price = hjsksjk.Price;
            } else if (garbage is YourArseProduct) {
                YourArseProduct sjksmg = (YourArseProduct)garbage;
                price = sjksmg.Ads*10;
            } else {
                price = garbage.Rating*100;
            }

            if ((bool)garbage.Viral)
                price *= 10;

            saleRate -= Global.Reputation/100;
            saleRate -= Global.Investors/100000;
            saleRate -= Global.MarketingBudget/50000;

            if (saleRate < 1)
                saleRate = 1;

            if (Engine.GetIdleFrames() % (ulong)saleRate*60 == 0 && Global.PausedTime == false) {
                // more stuff to break the game
                foreach (var item in Global.Researched) {
                    if (item.Name == "Overpriced products")
                        price *= 5;
                }

                garbage.Sales += 100;
                garbage.MoneyGot += price*100;
                Global.Money += price*100;
                Global.MonthlySales += price*100;
                Global.Products[Global.Products.Count-1] = (object)garbage;
            }
        }
        #endregion
        #region Debt
        if (Global.Money < 0 && Global.DebtOno == 0)
            Global.DebtOno = 1;

        if (Global.DebtOno == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("debt", "Debt");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.DebtOno = 2;
        }
        #endregion
        #region Bankrupt
        if (Global.Money < -50000 && GetNodeOrNull<Node2D>("/root/Bankrupt") == null && Global.DebtOno < 3) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Bankrupt.tscn");
            Node2D OK = (Node2D)yes.Instance();
            GetTree().Root.AddChild(OK);
        }
        #endregion
        #region No reputation
        if (Global.Reputation < 1 && GetNodeOrNull<Node2D>("/root/NoReputation") == null && Global.DebtOno < 3) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NoReputation.tscn");
            Node2D OK = (Node2D)yes.Instance();
            GetTree().Root.AddChild(OK);
        }
        #endregion
        #region Politics lol
        if (Global.Year % 4 == 0 && Global.Month == 1 && Global.Week == 1 && !Global.PoliticsAlreadyAppeared) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "PoliticsLol");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.PoliticsAlreadyAppeared = true;
        }
        #endregion
        #region Climate change
        if (Global.Year == 3 && Global.Month == 3 && Global.Week == 3 && !Global.ClimateChange) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "ClimateChange");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.ClimateChange = true;
        }
        #endregion
        #region A/C
        if (Global.Year == 1 && random.Next(0,50000) == 69 && !Global.Ac && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "AirConditioner");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ac = true;
        }
        #endregion
        #region Low reputation scam
        if (Global.Reputation < 25 && !Global.LowReputationScam && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "LowReputation");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.LowReputationScam = true;
        }
        #endregion
        #region $1M marketing unlock
        if (Global.Money > 10000000 && !Global.UnlockMarketing1 && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Marketing1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Taxes = 100000;
            Global.UnlockMarketing1 = true;
        }
        #endregion
        #region Viral
        if (Global.Products.Count > 0) {
            dynamic u = Global.Products[Global.Products.Count-1];
            if ((bool)u.Viral && !Global.ViralThingy && !Global.PausedTime) {
                var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
                Ball OK = (Ball)yes.Instance();
                OK.Init("news", "Viral");
                OK.ZIndex = 100;
                GetTree().Root.AddChild(OK);
                Global.ViralThingy = true;
            }
        }
        #endregion
        #region No entiendo scam
        if (Global.Year==1 && Global.Month==6 && Global.Week==1 && !Global.NoEntiendoScam && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "NoEntiendo");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoEntiendoScam = true;
        }
        #endregion
        #region $2.5M marketing unlock
        if (Global.Money > 50000000 && !Global.UnlockMarketing2 && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Marketing2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Overpriced products", 75));
            Global.UnlockMarketing2 = true;
        }
        #endregion
        #region Lottery
        if (Global.Month==6 && Global.Week==2 && !Global.Lottery && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "Lottery");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Lottery = true;
        }
        if (Global.Month==7)
            Global.Lottery = false;
        #endregion
        #region SpaceZ launches 1 billion satellites
        if (Global.Year==1 && Global.Month==12 && Global.Week==1 && !Global.SpacezSatellites &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpacezSatellites");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpacezSatellites = true;
        }
        #endregion
        #region SpaceZ lunar piss project
        if (Global.Year==2 && Global.Month==4 && Global.Week==3 && !Global.SpaceZLunarPissProject1 &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpacezLunarPissProject");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpaceZLunarPissProject1 = true;
        }
        #endregion
        #region NOSE lunar piss project
        if (Global.Year==2 && Global.Month==4 && Global.Week==4 && !Global.NoseLunarPissProject1 &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseLunarPissProject");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseLunarPissProject1 = true;
        }
        #endregion
        #region NOSE piss rocket explodes
        if (Global.Year==2 && Global.Month==8 && Global.Week==1 && !Global.NoseLunarPissProject2 &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseLunarPissProject2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseLunarPissProject2 = true;
        }
        #endregion
        #region SpaceZ launches piss rocket
        if (Global.Year==3 && Global.Month==1 && Global.Week==1 && !Global.SpacezPissOnTheMoon &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpacezLunarPissLaunch");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpacezPissOnTheMoon = true;
        }
        #endregion
        #region NOSE launches piss rocket
        if (Global.Year==3 && Global.Month==2 && Global.Week==4 && !Global.NosePissOnTheMoon &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseLunarPissLaunch");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NosePissOnTheMoon = true;
        }
        #endregion
        #region Epic Galaxies hotel
        if (Global.Year==3 && Global.Month==11 && Global.Week==1 && !Global.EpicGalaxiesHotel &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/EpicGalaxiesHotel");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EpicGalaxiesHotel = true;
        }
        #endregion
        #region SpaceZ mars landing
        if (Global.Year==4 && Global.Month==1 && Global.Week==1 && !Global.SpacezMarsLanding &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpacezMarsLanding");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpacezMarsLanding = true;
        }
        #endregion
        #region NOSE mars landing
        if (Global.Year==4 && Global.Month==7 && Global.Week==1 && !Global.NoseMarsLanding &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseMarsLanding");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseMarsLanding = true;
        }
        #endregion
        #region earth orbit trash
        if (Global.Year==4 && Global.Month==12 && Global.Week==1 && !Global.EarthOrbitTrash &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/EarthOrbitTrash");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EarthOrbitTrash = true;
        }
        #endregion
        #region earth orbit trash 2: 2 earth 2 trash
        if (Global.Year==5 && Global.Month==1 && Global.Week==2 && !Global.EarthOrbitTrash2 &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/EarthOrbitTrash2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EarthOrbitTrash2 = true;
        }
        #endregion
        #region unlock space colonization
        if (Global.Year==3 && Global.Month==5 && Global.Week==1 && !Global.UnlockSpaceColonization &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/SpaceColonization");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Colonization", 550));
            Global.UnlockSpaceColonization = true;
        }
        #endregion
        #region spacez colonizes mars
        if (Global.Year==5 && Global.Month==7 && Global.Week==1 && !Global.SpacezColonization &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpacezMelonland");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpacezColonization = true;
        }
        #endregion
        #region nose colonizes mars
        if (Global.Year==6 && Global.Month==1 && Global.Week==1 && !Global.NoseColonization &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseNewOhio");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseColonization = true;
        }
        #endregion
        #region your mom book
        if (Global.Year==2 && Global.Month==4 && Global.Week==1 && !Global.YourMom1 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom1 = true;
        }
        #endregion
        #region dosney book movie
        if (!Global.BookMovie && !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "News/Books/Dosney");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.BookMovie = true;
        }
        #endregion
        #region your mom book 2
        if (Global.Year==3 && Global.Month==1 && Global.Week==1 && !Global.YourMom2 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom2 = true;
        }
        #endregion
        #region your mom book 3
        if (Global.Year==4 && Global.Month==2 && Global.Week==1 && !Global.YourMom3 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom3");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom3 = true;
        }
        #endregion
        #region your mom book 4
        if (Global.Year==5 && Global.Month==3 && Global.Week==1 && !Global.YourMom4 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom4");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom4 = true;
        }
        #endregion
        #region your mom book 5
        if (Global.Year==6 && Global.Month==4 && Global.Week==1 && !Global.YourMom5 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom5");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom5 = true;
        }
        #endregion
        #region your mom book 6
        if (Global.Year==7 && Global.Month==5 && Global.Week==1 && !Global.YourMom6 &&
        !Global.PausedTime && Global.Industries[0]=="books") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Books/YourMom6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YourMom6 = true;
        }
        #endregion
        #region bad medical thing
        if (!Global.BadMedicalThing && !Global.PausedTime && Global.Industries[0]=="medical") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "News/Medical/BadMedicalThing");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.BadMedicalThing = true;
        }
        #endregion
        #region THE CURE FOR CANCER
        if (Global.Year==5 && Global.Month==4 && Global.Week==3 && !Global.TheCureForCancer &&
        !Global.PausedTime && Global.Industries[0]=="medical") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Medical/TheCureForCancer");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.TheCureForCancer = true;
        }
        #endregion
        #region reverse disease
        if (Global.Year==2 && Global.Month==4 && Global.Week==1 && !Global.ReverseDisease &&
        !Global.PausedTime && Global.Industries[0]=="medical") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Medical/ReverseDisease");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.ReverseDisease = true;
        }
        #endregion
        #region $10k taxes
        if (Global.Money > 1000000 && !Global.Taxes1 && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Taxes1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Taxes = 10000;
            Global.Taxes1 = true;
        }
        #endregion
        #region $1m taxes
        if (Global.Money > 100000000 && !Global.Taxes2 && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Taxes2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Taxes = 1000000;
            Global.Taxes2 = true;
        }
        #endregion
        #region more taxes and a lab that doesn't exist yet omg omg omg omg
        if (Global.Money > 1000000000 && !Global.Lab && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Lab");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Taxes = 10000000;
            Global.Lab = true;
        }
        #endregion
        #region ecs year 1
        if (Global.Year==1 && Global.Month==12 && Global.Week==4 && !Global.Ecs1 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs1 = true;
        }
        #endregion
        #region ecs year 2
        if (Global.Year==2 && Global.Month==12 && Global.Week==4 && !Global.Ecs2 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs2 = true;
        }
        #endregion
        #region ecs year 3
        if (Global.Year==3 && Global.Month==12 && Global.Week==4 && !Global.Ecs3 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs3");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs3 = true;
        }
        #endregion
        #region ecs year 4
        if (Global.Year==4 && Global.Month==12 && Global.Week==4 && !Global.Ecs4 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs4");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs4 = true;
        }
        #endregion
        #region ecs year 5
        if (Global.Year==5 && Global.Month==12 && Global.Week==4 && !Global.Ecs5 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs5");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs5 = true;
        }
        #endregion
        #region ecs year 6
        if (Global.Year==6 && Global.Month==12 && Global.Week==4 && !Global.Ecs6 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs6 = true;
        }
        #endregion
        #region ecs year 7
        if (Global.Year==7 && Global.Month==12 && Global.Week==4 && !Global.Ecs7 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs7");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs7 = true;
        }
        #endregion
        #region ecs year 8
        if (Global.Year==8 && Global.Month==12 && Global.Week==4 && !Global.Ecs8 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs8");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs8 = true;
        }
        #endregion
        #region ecs year 9
        if (Global.Year==9 && Global.Month==12 && Global.Week==4 && !Global.Ecs9 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs9");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs9 = true;
        }
        #endregion
        #region ecs year 10
        if (Global.Year==10 && Global.Month==12 && Global.Week==4 && !Global.Ecs10 &&
        !Global.PausedTime && Global.Industries[0]=="computers") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Computer/Ecs10");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Ecs10 = true;
        }
        #endregion
        #region prince in england
        if (Global.Year==4 && Global.Month==1 && Global.Week==4 && !Global.PrinceInEngland &&
        !Global.PausedTime && random.Next(0,2) == 0) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "PrinceInEngland");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.PrinceInEngland = true;
        }
        #endregion
        #region infinite coffee machine
        if (Global.Year==2 && Global.Month==8 && Global.Week==1 && !Global.InfiniteCoffeeMachine &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "InfiniteCoffeeMachine");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.InfiniteCoffeeMachine = true;
        }
        #endregion
        #region infinite tea machine
        if (Global.Year==3 && Global.Month==4 && Global.Week==1 && !Global.InfiniteTeaMachine &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "InfiniteTeaMachine");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.InfiniteTeaMachine = true;
        }
        #endregion
        #region james james II photos
        if (Global.Year==4 && Global.Month==11 && Global.Week==1 && !Global.JamesPhotos &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "JamesJames2Photos");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.JamesPhotos = true;
        }
        #endregion
        #region white room
        if (Global.Year==5 && Global.Month==3 && Global.Week==1 && !Global.WhiteRoom &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "WhiteRoom");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.WhiteRoom = true;
        }
        #endregion
        #region floating office
        if (Global.Year==6 && Global.Month==9 && Global.Week==1 && !Global.FloatingOffice &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "FloatingOffice");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.FloatingOffice = true;
        }
        #endregion
        #region fart smells
        if (Global.Year==7 && Global.Month==11 && Global.Week==1 && !Global.FartSmells &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "FartSmells");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.FartSmells = true;
        }
        #endregion
        #region office inside office
        if (Global.Year==8 && Global.Month==8 && Global.Week==1 && !Global.OfficeInsideOffice &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "OfficeInsideOffice");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.OfficeInsideOffice = true;
        }
        #endregion
        #region money printer
        if (Global.Year==9 && Global.Month==2 && Global.Week==1 && !Global.MoneyPrinter &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "MoneyPrinter");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.MoneyPrinter = true;
        }
        #endregion
        #region move to paintopia
        if (Global.Year==10 && Global.Month==10 && Global.Week==1 && !Global.MoveToPaintopia &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "MoveToPaintopia");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.MoveToPaintopia = true;
        }
        #endregion
        base._Process(delta);
    }
}