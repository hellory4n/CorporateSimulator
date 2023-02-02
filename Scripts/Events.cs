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
        if (Global.Year==1 && Global.Month==6 && Global.Week==2 && !Global.NoEntiendoScam && !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "NoEntiendo");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoEntiendoScam = true;
        }
        #endregion
        #region $10M marketing unlock
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
        base._Process(delta);
    }
}