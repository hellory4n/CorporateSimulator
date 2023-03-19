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
        }

        Text = movie;
        base._Ready();
    }
}
