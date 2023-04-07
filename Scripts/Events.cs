using Godot;
using System;
using Newtonsoft.Json;

public class Events : Node2D {
    Random random = new Random();

    public override void _Process(float delta) {
        #region Sales
        // we can't sell void
        if (Global.Products.Count > 0) {
            // sorry
            Product garbageProduct = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
                Global.Products[Global.Products.Count-1]));
            object garbage = Global.Products[Global.Products.Count-1];
            dynamic garbageDynamic = Global.Products[Global.Products.Count-1];
            int price = 0;
            double saleRate = 160;
            int sales = 100;

            // garbage price
            if (garbageProduct.Type == "computer") {
                ComputerProduct shjksj = JsonConvert.DeserializeObject<ComputerProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                price = shjksj.Price;
                sales = 2*garbageProduct.Rating;
            } else if (garbageProduct.Type == "tv") {
                TvProduct hjskosp = JsonConvert.DeserializeObject<TvProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                price = (int)hjskosp.Ads/10;
                sales = 1000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "apps") {
                AppProduct jskiops = JsonConvert.DeserializeObject<AppProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                price = (int)jskiops.Algorithm/10;
                sales = 1000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "phone") {
                PhoneProduct hjsksjk = JsonConvert.DeserializeObject<PhoneProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                price = hjsksjk.Price;
                sales = 10*garbageProduct.Rating;
            } else if (garbageProduct.Type == "yourarse") {
                YourArseProduct sjksmg = JsonConvert.DeserializeObject<YourArseProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                price = (int)sjksmg.Ads/20;
                sales = 2000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "rocket") {
                price = 100;
                sales = 100*garbageProduct.Rating;
            } else if (garbageProduct.Type == "food") {
                price = 5;
                sales = 2000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "book") {
                price = 20;
                sales = 50*garbageProduct.Rating;
            } else if (garbageProduct.Type == "medical") {
                price = 50;
                sales = 200*garbageProduct.Rating;
            } else if (garbageProduct.Type == "electronics") {
                price = 400;
                sales = 25*garbageProduct.Rating;
            } else if (garbageProduct.Type == "music") {
                price = 5;
                sales = 2000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "media") {
                price = 10;
                sales = 1000*garbageProduct.Rating;
            } else if (garbageProduct.Type == "game") {
                price = 60;
                sales = 167*garbageProduct.Rating;
            }

            if ((bool)garbageProduct.Viral)
                price *= 10;

            saleRate -= Global.Reputation/100;
            saleRate -= Global.Investors/100000;
            saleRate -= Global.MarketingBudget/50000;

            if (saleRate < 1)
                saleRate = 1;
            
            int veryRealSecond = 3;
            if (Global.TimeSpeed == 2)
                veryRealSecond = 5;
            if (Global.TimeSpeed == 3)
                veryRealSecond = 10;
            
            ulong fart = (ulong)(saleRate/veryRealSecond);

            if (Engine.GetIdleFrames() % fart == 0 && Global.PausedTime == false) {
                // is the product 3 months old?
                string[] yes = garbageProduct.ReleaseDate.Split(" ");
                int garbageYear = int.Parse(yes[0].Substring(1));
                int garbageMonth = int.Parse(yes[1].Substring(1));
                int monthsOld = (Global.Year - garbageYear) * 12 + (Global.Month - garbageMonth);

                if (monthsOld < 3) {
                    // more stuff to break the game
                    foreach (var item in Global.Researched) {
                        if (item.Name == "Overpriced products") {
                            price *= 5;
                        }
                    }

                    garbageDynamic.Sales += sales;
                    garbageDynamic.MoneyGot += price*sales;
                    Global.Money += price*sales;
                    Global.MonthlySales += price*sales;
                    Global.Products[Global.Products.Count-1] = (object)garbageDynamic;
                } else {
                    if (!Global.DiscontinuedProduct) {
                        var ggdfh = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
                        Ball OK = (Ball)ggdfh.Instance();
                        OK.Init("news", "DiscontinuedProduct");
                        OK.ZIndex = 100;
                        GetTree().Root.AddChild(OK);
                        Global.DiscontinuedProduct = true;
                    }
                }
            }
            GD.Print("sales: " + sales);
            GD.Print("price: " + price);
        }
        #endregion
        #region Debt
        if (Global.Money < 0 && Global.DebtOno == 0)
            Global.DebtOno = 1;

        if (Global.DebtOno == 1 && !Global.PausedTime) {
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
            Global.PausedTime = true;
            GetTree().Root.AddChild(OK);
        }
        #endregion
        #region No reputation
        if (Global.Reputation < 1 && GetNodeOrNull<Node2D>("/root/NoReputation") == null && Global.DebtOno < 3) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NoReputation.tscn");
            Node2D OK = (Node2D)yes.Instance();
            Global.PausedTime = true;
            GetTree().Root.AddChild(OK);
        }
        #endregion
        #region Politics lol
        if (Global.Year % 4 == 0 && Global.Month == 1 && Global.Week == 1 && !Global.PoliticsAlreadyAppeared &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "PoliticsLol");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.PoliticsAlreadyAppeared = true;
        }
        #endregion
        #region Climate change
        if (Global.Year == 3 && Global.Month == 3 && Global.Week == 3 && !Global.ClimateChange &&!Global.PausedTime) {
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
            Global.UnlockedResearch.Add(new ResearchSave("Space Agriculture", 1000));
            Global.UnlockedResearch.Add(new ResearchSave("Space Mining", 2000));
            Global.UnlockedResearch.Add(new ResearchSave("Space Industrialism", 5000));
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
        #region melonet
        if (Global.Year==6 && Global.Month==5 && Global.Week==1 && !Global.Melonet &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/Melonet");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Melonet = true;
        }
        #endregion
        #region mars stock market crashes
        if (Global.Year==7 && Global.Month==3 && Global.Week==2 && !Global.MarsStockMarketCrash &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/MarsStockCrash");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.MarsStockMarketCrash = true;
        }
        #endregion
        #region meloncash
        if (Global.Year==7 && Global.Month==5 && Global.Week==1 && !Global.Meloncash &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/Meloncash");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Meloncash = true;
        }
        #endregion
        #region nose colonizes uranus
        if (Global.Year==7 && Global.Month==12 && Global.Week==1 && !Global.NoseUranus &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseUranus");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseUranus = true;
        }
        #endregion
        #region nose launches terraforming stuff to uranus
        if (Global.Year==8 && Global.Month==7 && Global.Week==1 && !Global.NoseUranusTerraforming &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/NoseUranusTerraforming");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NoseUranusTerraforming = true;
        }
        #endregion
        #region spacez piss ring
        if (Global.Year==8 && Global.Month==12 && Global.Week==1 && !Global.SpaceZPissRing &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpaceZPissRing");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpaceZPissRing = true;
        }
        #endregion
        #region mars stock market crash again
        if (Global.Year==9 && Global.Month==3 && Global.Week==1 && !Global.MarsStockMarketCrashAgain &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/MarsStockCrashAgain");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.MarsStockMarketCrashAgain= true;
        }
        #endregion
        #region melonland invades new ohio
        if (Global.Year==9 && Global.Month==4 && Global.Week==1 && !Global.SpaceZInvasion &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpaceZInvasion");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpaceZInvasion = true;
        }
        #endregion
        #region uranus landing
        if (Global.Year==9 && Global.Month==7 && Global.Week==1 && !Global.UranusLanding &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/UranusLanding");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UranusLanding = true;
        }
        #endregion
        #region njksbjehuitojbhjikle
        if (Global.Year==10 && Global.Month==3 && Global.Week==1 && !Global.UranusState &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/UranusState");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UranusState = true;
        }
        #endregion
        #region piss ring is done
        if (Global.Year==10 && Global.Month==7 && Global.Week==1 && !Global.SpaceZPissRingFinish &&
        !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/SpaceZPissRingFinish");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.SpaceZPissRingFinish = true;
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
        #region interview
        if (Global.Year==5 && Global.Month==7 && Global.Week==2 && !Global.Interview &&
        !Global.PausedTime && random.Next(2) == 1) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "Interview0");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Interview = true;
        }
        #endregion
        #region offended
        if (!Global.Offended && !Global.PausedTime && Global.Products.Count > 0) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "Offended");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Offended = true;
        }
        #endregion
        #region 4d music
        if (Global.Year==2 && Global.Month==1 && Global.Week==1 && !Global._4DMusic &&
        !Global.PausedTime && Global.Industries[0]=="music") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Music/4DMusic");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("4D Music", 100));
            Global._4DMusic = true;
        }
        #endregion
        #region interdimensional music
        if (Global.Year==4 && Global.Month==1 && Global.Week==1 && !Global.InterdimensionalMusic &&
        !Global.PausedTime && Global.Industries[0]=="music") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Music/InterdimensionalMusic");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Interdimensional Music", 150));
            Global.InterdimensionalMusic = true;
        }
        #endregion
        #region universe-breaking music
        if (Global.Year==6 && Global.Month==1 && Global.Week==1 && !Global.UniverseBreakingMusic &&
        !Global.PausedTime && Global.Industries[0]=="music") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Music/UniverseBreakingMusic");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Universe-breaking Music", 200));
            Global.UniverseBreakingMusic = true;
        }
        #endregion
        #region music that makes new multiverses
        if (Global.Year==8 && Global.Month==1 && Global.Week==1 && !Global.MusicThatMakesNewMultiverses &&
        !Global.PausedTime && Global.Industries[0]=="music") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Music/MusicThatMakesNewMultiverses");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Music that makes new multiverses", 200));
            Global.MusicThatMakesNewMultiverses = true;
        }
        #endregion
        #region NOISES II
        if (Global.Year==10 && Global.Month==1 && Global.Week==1 && !Global.NoisesII &&
        !Global.PausedTime && Global.Industries[0]=="music") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Music/NoisesII");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("NOISES II", 250));
            Global.NoisesII = true;
        }
        #endregion
        #region food gives messaging app disease
        if (!Global.MessagingAppDisease && !Global.PausedTime && Global.Industries[0]=="food") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "News/Food/MessagingAppDisease");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.MessagingAppDisease = true;
        }
        #endregion
        #region appliance security breach
        if (!Global.ApplianceSecurityBreach && !Global.PausedTime && Global.Industries[0]=="electronics") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Appliances/SecurityBreach");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.ApplianceSecurityBreach = true;
        }
        #endregion
        #region boom
        if (!Global.Boom && !Global.PausedTime &&
            (Global.Industries[0]=="computers" || Global.Industries[0]=="phones")) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "News/Computer/Boom");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Boom = true;
        }
        #endregion
        #region ecs phone year 1
        if (Global.Year==1 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone1 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone1 = true;
        }
        #endregion
        #region ecs phone year 2
        if (Global.Year==2 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone2 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone2 = true;
        }
        #endregion
        #region ecs phone year 3
        if (Global.Year==3 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone3 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs3");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone3 = true;
        }
        #endregion
        #region ecs phone year 4
        if (Global.Year==4 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone4 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs4");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone4 = true;
        }
        #endregion
        #region ecs phone year 5
        if (Global.Year==5 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone5 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs5");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone5 = true;
        }
        #endregion
        #region ecs phone year 6
        if (Global.Year==6 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone6 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone6 = true;
        }
        #endregion
        #region ecs phone year 7
        if (Global.Year==7 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone7 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs7");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone7 = true;
        }
        #endregion
        #region ecs phone year 8
        if (Global.Year==8 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone8 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs8");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone8 = true;
        }
        #endregion
        #region ecs phone year 9
        if (Global.Year==9 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone9 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs9");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone9 = true;
        }
        #endregion
        #region ecs phone year 10
        if (Global.Year==10 && Global.Month==12 && Global.Week==4 && !Global.EcsPhone10 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("ecs", "News/Phone/Ecs10");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.EcsPhone10 = true;
        }
        #endregion
        #region new pork times y1 m6
        if (Global.Year==1 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY1M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y1M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY1M6 = true;
        }
        #endregion
        #region breaking news y1 m8
        if (Global.Year==1 && Global.Month==8 && Global.Week==1 && !Global.NPTimesY1M8 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY1M8");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY1M8 = true;
        }
        #endregion
        #region breaking news y1 m12
        if (Global.Year==1 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY1M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y1M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY1M12 = true;
        }
        #endregion
        #region breaking news y2 m6
        if (Global.Year==2 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY2M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y2M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY2M6 = true;
        }
        #endregion
        #region breaking news y2 m12
        if (Global.Year==2 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY2M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y2M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY2M12 = true;
        }
        #endregion
        #region breaking news y3 m6
        if (Global.Year==3 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY3M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y3M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY3M6 = true;
        }
        #endregion
        #region breaking news y3 m12
        if (Global.Year==3 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY3M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y3M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY3M12 = true;
        }
        #endregion
        #region breaking news y4 m6
        if (Global.Year==4 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY4M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y4M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY4M6 = true;
        }
        #endregion
        #region breaking news y4 m12
        if (Global.Year==4 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY4M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y4M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY4M12 = true;
        }
        #endregion
        #region breaking news y5 m6
        if (Global.Year==5 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY5M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y5M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY5M6 = true;
        }
        #endregion
        #region breaking news y5 m12
        if (Global.Year==5 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY5M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y5M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY5M12 = true;
        }
        #endregion
        #region breaking news y6 m6
        if (Global.Year==6 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY6M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y6M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY6M6 = true;
        }
        #endregion
        #region breaking news y6 m12
        if (Global.Year==6 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY6M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y6M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY6M12 = true;
        }
        #endregion
        #region breaking news y7 m6
        if (Global.Year==7 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY7M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y7M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY7M6 = true;
        }
        #endregion
        #region breaking news y7 m7
        if (Global.Year==7 && Global.Month==7 && Global.Week==3 && !Global.NPTimesY7M7 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY7M7");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY7M7 = true;
        }
        #endregion
        #region breaking news y7 m12
        if (Global.Year==7 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY7M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y7M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY7M12 = true;
        }
        #endregion
        #region breaking news y8 m6
        if (Global.Year==8 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY8M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y8M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY8M6 = true;
        }
        #endregion
        #region breaking news y8 m12
        if (Global.Year==8 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY8M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y8M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY8M12 = true;
        }
        #endregion
        #region breaking news y9 m4
        if (Global.Year==9 && Global.Month==4 & Global.Week==3 && !Global.NPTimesY9M4 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY9M4");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY9M4 = true;
        }
        #endregion
        #region breaking news y9 m6
        if (Global.Year==9 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY9M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y9M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY9M6 = true;
        }
        #endregion
        #region breaking news y9 m8
        if (Global.Year==9 && Global.Month==8 && Global.Week==3 && !Global.NPTimesY9M8 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY9M8");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY9M8 = true;
        }
        #endregion
        #region breaking news y9 m9
        if (Global.Year==9 && Global.Month==9 && Global.Week==3 && !Global.NPTimesY9M9 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY9M9");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY9M9 = true;
        }
        #endregion
        #region breaking news y9 m12
        if (Global.Year==9 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY9M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y9M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY9M12 = true;
        }
        #endregion
        #region breaking news y10 m1
        if (Global.Year==10 && Global.Month==1 && Global.Week==3 && !Global.NPTimesY10M1 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY10M1");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY10M1 = true;
        }
        #endregion
        #region breaking news y10 m6
        if (Global.Year==10 && Global.Month==6 && Global.Week==3 && !Global.NPTimesY10M6 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y10M6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY10M6 = true;
        }
        #endregion
        #region breaking news y10 m8
        if (Global.Year==10 && Global.Month==8 && Global.Week==3 && !Global.NPTimesY10M8 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/BreakingNewsY10M8");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY10M8 = true;
        }
        #endregion
        #region breaking news y10 m12
        if (Global.Year==10 && Global.Month==12 && Global.Week==3 && !Global.NPTimesY10M12 &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/NPTimes/Y10M12");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.NPTimesY10M12 = true;
        }
        #endregion
        #region cookiedisc
        if (Global.Year == 5 && Global.Month == 1 && Global.Week == 1 && !Global.CookieDisc &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/CookieDisc");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("CookieDisc", 100));
            Global.CookieDisc = true;
        }
        #endregion
        #region smartphone 2
        if (Global.Year == 7 && Global.Month == 1 && Global.Week == 1 && !Global.Smartphone2 &&
        !Global.PausedTime && Global.Industries[0]=="phones") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("unlock", "Unlock/Smartphone2");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.UnlockedResearch.Add(new ResearchSave("Smartphone 2", 250));
            Global.Smartphone2 = true;
        }
        #endregion
        #region rocket explodes
        if (!Global.RocketBoom && !Global.PausedTime && Global.Industries[0]=="space") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Space/RocketBoom");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.RocketBoom = true;
        }
        #endregion
        #region rooster
        if (Global.Month==12 && Global.Week==4 && !Global.Rooster && !Global.PausedTime &&
        Global.Industries[0]=="media") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Media/Rooster");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Rooster = true;
        }
        if (Global.Week == 1) {
            Global.Rooster = false;
        }
        #endregion
        #region hola by trickstarter
        if (Global.Year==2 && Global.Month==10 && Global.Week==1 && !Global.Hola && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/TrickStarterHola");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Hola = true;
        }
        #endregion
        #region gamestation 5 pro
        if (Global.Year==4 && Global.Month==5 && Global.Week==1 && !Global.GameStation5Pro && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/GameStation5Pro");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.GameStation5Pro = true;
        }
        #endregion
        #region xcube series z
        if (Global.Year==4 && Global.Month==9 && Global.Week==1 && !Global.XcubeSeriesZ && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/XcubeSeriesZ");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.XcubeSeriesZ = true;
        }
        #endregion
        #region we us (not we or we you)
        if (Global.Year==6 && Global.Month==9 && Global.Week==3 && !Global.WeUs && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/WeUs");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.WeUs = true;
        }
        #endregion
        #region xcube wrong
        if (Global.Year==6 && Global.Month==4 && Global.Week==1 && !Global.XcubeWrong && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/XcubeWrong");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.XcubeWrong = true;
        }
        #endregion
        #region gamestation 6
        if (Global.Year==6 && Global.Month==5 && Global.Week==1 && !Global.GameStation6 && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/GameStation6");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.GameStation6 = true;
        }
        #endregion
        #region goggles standing
        if (Global.Year==8 && Global.Month==7 && Global.Week==1 && !Global.Standing && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/Standing");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.Standing = true;
        }
        #endregion
        #region rip goggles standing y8-y8
        if (Global.Year==8 && Global.Month==8 && Global.Week==2 && !Global.StandingRip && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/StandingRip");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.StandingRip = true;
        }
        #endregion
        #region we all
        if (Global.Year==10 && Global.Month==1 && Global.Week==2 && !Global.WeAll && !Global.PausedTime
        && Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/WeAll");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.WeAll = true;
        }
        #endregion
        #region year of the game
        if (Global.Month==12 && Global.Week==4 && !Global.YearOfTheGame && !Global.PausedTime &&
        Global.Industries[0]=="games") {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("news", "News/Games/YearOfTheGame");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.YearOfTheGame = true;
        }
        if (Global.Week == 1) {
            Global.YearOfTheGame = false;
        }
        #endregion
        #region darkstone investment
        if (Global.Year==1 && Global.Month==2 && Global.Week==2 && !Global.DarkStoneInvestment &&
        !Global.PausedTime) {
            var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Ball.tscn");
            Ball OK = (Ball)yes.Instance();
            OK.Init("email", "Investment");
            OK.ZIndex = 100;
            GetTree().Root.AddChild(OK);
            Global.DarkStoneInvestment = true;
        }
        #endregion
        base._Process(delta);
    }
}