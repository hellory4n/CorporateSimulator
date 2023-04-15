using Godot;
using System;
using Newtonsoft.Json;

public class Reviews : Node2D {
    Random soRandom = new Random();

    public override void _Ready() {
        // so the game doesn't explode
        if (Global.Products.Count > 0) {
            // sorry
            Product garbage = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
                Global.Products[Global.Products.Count-1]));
            GetNode<Label>("Title").Text = "Reviews of " + Global.CompanyName+ "'s latest product";
            GetNode<Label>("Review").Text = "Reviews of " + Global.CompanyName + "'s latest product";
            string[] reviews = {"not loaded", "not loaded", "not loaded", "not loaded"};

            // reviewers
            string[] reviewers = {"someone 1", "someone 2", "someone 3", "someone 4"};
            switch (garbage.Type) {
                case "rocket":
                    reviewers = new string[]{"epic scientist", "InsaneScientist™", "Bob. (scientist)", "NOSE"};
                    break;
                case "apps":
                    reviewers = new string[]{"Epic Apps", "iUseApps", "Goggles", "Pineapple"};
                    break;
                case "book":
                    reviewers = new string[]{"Epic Books", "read", "Amazing", "BadReviews.com"};
                    break;
                case "computer":
                    reviewers = new string[]{"Linus Drop Tips", "PC Magnifier", "James's PC", "FakeReviews.com"};
                    break;
                case "electronics":
                    reviewers = new string[]{"Dad", "Toaster User", "FRIGDE.NET", "Goggles"};
                    break;
                case "food":
                    reviewers = new string[]{"Epic Chef", "Gordom Ranmsey", "Master Chef", "BadReviews.com"};
                    break;
                case "media":
                    reviewers = new string[]{"Fine Tomatoes", "ABCd", "Infracritic", "BadReviews.com"};
                    break;
                case "tv":
                    reviewers = new string[]{"Fine Tomatoes", "ABCd", "Infracritic", "BadReviews.com"};
                    break;
                case "medical":
                    reviewers = new string[]{"Steve (doctor)", "John (doctor)", "Hjkgnsj (doctor)", "Government"};
                    break;
                case "music":
                    reviewers = new string[]{"MusicToMyEars", "Everything Hz", "No music", "Moosic.com"};
                    break;
                case "phone":
                    reviewers = new string[]{"Mrwhosetheemployee", "Mark Yellowlee", "Explosive Phones", "phone.net"};
                    break;
                case "yourarse":
                    reviewers = new string[]{"BadReviews.com", "Terrible Reviews", "EpicReviews.net", "LegitReviews.org"};
                    break;
                case "game":
                    reviewers = new string[]{"ING", "Infracritic", "GameCenter", "BadReviews.com"};
                    break;
            }
            
            // reviews
            if (garbage.Rating < 5) {
                reviews = new string[]{"This is garbage", "I can make something better on the toilet",
                    "Never seen something of such quality since Doors Vision", "Stop it, get some help."};
            } else if (garbage.Rating > 4 && garbage.Rating < 7) {
                reviews = new string[]{"OK", "Meh", "Boring", "A"};
            } else if (garbage.Rating > 6 && garbage.Rating < 10) {
                reviews = new string[]{"Very cool", "Better than what I can make on the toilet", "Cool", "Epic"};
            } else if (garbage.Rating == 10) {
                reviews = new string[]{"This is a masterpiece", "Insanely epic", "Very cool x2", "Fantastic"};
            }

            for (int i = 1; i < 5; i++) {
                GetNode<Label>("Rating"+i).Text = garbage.Rating.ToString();
                GetNode<Label>("Reviewer"+i).Text = reviewers[i-1];
                GetNode<Label>("Review"+i).Text = reviews[i-1];
            }

            if (garbage.Rating > 5)
                Global.Reputation += garbage.Rating-5;
            else
                Global.Reputation -= 6-garbage.Rating;
            
            // release dates
            dynamic uh = Global.Products[Global.Products.Count-1];
            uh.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;            

            // mues
            Global.DiscontinuedProduct = false;

            // money money money
            if (soRandom.Next(0,4) == 0)
                uh.Viral = true;
            
            Global.Products[Global.Products.Count-1] = (object)uh;
            Global.ViralThingy = false;

            if (garbage.Type == "book" && garbage.Rating == 10)
                Global.BookMovie = false;
            
            if (garbage.Type == "medical" && garbage.Rating < 5 && Global.Money > 4)
                Global.BadMedicalThing = false;
            
            if (soRandom.Next(0,10) == 2)
                Global.Offended = false;
            
            if (soRandom.Next(0,4) == 0 && garbage.Type == "food")
                Global.MessagingAppDisease = false;
            
            if (garbage.Type == "electronics") {
                // uhh
                ElectronicsProduct trash = JsonConvert.DeserializeObject<ElectronicsProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                if (trash.Security < 6)
                    Global.ApplianceSecurityBreach = false;
            }

            if (garbage.Type == "rocket") {
                // uhh
                SpaceProduct trash = JsonConvert.DeserializeObject<SpaceProduct>(
                    JsonConvert.SerializeObject(Global.Products[Global.Products.Count-1]));
                if (trash.Safety < 51 || trash.Fuel < trash.Speed)
                    Global.RocketBoom = false;
            }

            if (soRandom.Next(0,7) == 0 && (garbage.Type == "computer" || garbage.Type == "phone"))
                Global.Boom = false;
        } else {
            QueueFree();
        }
        base._Ready();
    }
}
