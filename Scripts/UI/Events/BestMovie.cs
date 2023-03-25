using Godot;
using System;
using Newtonsoft.Json;

public class BestMovie : Label {
    public override void _Ready() {
        string movie = "";

        if (Global.Products.Count > 0) {
            Product trash = JsonConvert.DeserializeObject<Product>(JsonConvert.SerializeObject(
                Global.Products[Global.Products.Count-1]));
            if (trash.Rating == 10)
                movie = trash.Name;
        }

        if (movie == "") {
            if (Global.Industries[0] == "media") {
                switch (Global.Year) {
                    case 1: movie = "The World of S.T.U.F.F."; break;
                    case 2: movie = "The World of S.T.U.F.F. 2: 2 World 2 S.T.U.F.F."; break;
                    case 3: movie = "The World of S.T.U.F.F. 3: Tokyo Grift"; break;
                    case 4: movie = "World S.T.U.F.F. 4: A New Nope"; break;
                    case 5: movie = "S.T.U.F.F. Five: River Heist"; break;
                    case 6: movie = "World S.T.U.F.F. 6"; break;
                    case 7: movie = "S.T.U.F.F. 7"; break;
                    case 8: movie = "The Fate of the S.T.U.F.F."; break;
                    case 9: movie = "S9: The S.T.U.F.F. Saga"; break;
                    case 10: movie = "S.T.U.F.F. X"; break;
                }
            } else if (Global.Industries[0] == "games") {
                switch (Global.Year) {
                    case 1: movie = "Final Individuals"; break;
                    case 2: movie = "Mining & Crafting 2: 2 Mining 2 Crafting"; break;
                    case 3: movie = "Great Car Robbery VI"; break;
                    case 4: movie = "Underview"; break;
                    case 5: movie = "Breathing in the Wild"; break;
                    case 6: movie = "War Gods"; break;
                    case 7: movie = "Goose Game with a Name"; break;
                    case 8: movie = "Demon"; break;
                    case 9: movie = "Encryption: The Game"; break;
                    case 10: movie = "Elder Sings"; break;
                }
            }
        }

        Text = movie;
        base._Ready();
    }
}
