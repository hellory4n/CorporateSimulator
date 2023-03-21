using Godot;
using System;

public class GameFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // calculate rating
        #region i'm sorry
        string[] themeGenreCombinations = {"action,airplane,10", "action,aliens,10", "action,alternate history,10", "action,business,0", "action,city,3", "action,comedy,0", "action,cyberpunk,10", "action,dance,3", "action,detective,0", "action,dungeon,10", "action,evolution,3", "action,fantasy,10", "action,fashion,0", "action,game dev,0", "action,government,0", "action,hacking,3", "action,history,5", "action,horror,10", "action,hospital,0", "action,hunting,10", "action,law,0", "action,life,0", "action,martial arts,10", "action,medieval,10", "action,military,10", "action,movies,5", "action,music,10", "action,mystery,0", "action,ninja,10", "action,pirate,5", "action,post apocalyptic,10", "action,prison,10", "action,racing,7", "action,rhythm,10", "action,romance,0", "action,school,5", "action,sci-fi,10", "action,space,10", "action,sports,10", "action,spy,10", "action,superheroes,10", "action,surgery,5", "action,time travel,7", "action,transport,0", "action,ufo,10", "action,vampire,10", "action,virtual pet,0", "action,vocabulary,0", "action,werewolf,10", "action,wild west,7", "action,zombies,10", "adventure,airplane,0", "adventure,aliens,5", "adventure,alternate history,5", "adventure,business,5", "adventure,city,0", "adventure,comedy,10", "adventure,cyberpunk,5", "adventure,dance,0", "adventure,detective,10", "adventure,dungeon,5", "adventure,evolution,0", "adventure,fantasy,10", "adventure,fashion,5", "adventure,game dev,3", "adventure,government,0", "adventure,hacking,5", "adventure,history,5", "adventure,horror,10", "adventure,hospital,0", "adventure,hunting,7", "adventure,law,10", "adventure,life,10", "adventure,martial arts,5", "adventure,medieval,10", "adventure,military,0", "adventure,movies,5", "adventure,music,7", "adventure,mystery,10", "adventure,ninja,5", "adventure,pirate,10", "adventure,post apocalyptic,5", "adventure,prison,10", "adventure,racing,0", "adventure,rhythm,3", "adventure,romance,10", "adventure,school,10", "adventure,sci-fi,10", "adventure,space,5", "adventure,sports,0", "adventure,spy,10", "adventure,superheroes,0", "adventure,surgery,3", "adventure,time travel,10", "adventure,transport,0", "adventure,ufo,5", "adventure,vampire,5", "adventure,virtual pet,5", "adventure,vocabulary,0", "adventure,werewolf,5", "adventure,wild west,3", "adventure,zombies,7", "rpg,airplane,5", "rpg,aliens,10", "rpg,alternate history,10", "rpg,business,5", "rpg,city,3", "rpg,comedy,5", "rpg,cyberpunk,10", "rpg,dance,0", "rpg,detective,10", "rpg,dungeon,10", "rpg,evolution,0", "rpg,fantasy,10", "rpg,fashion,10", "rpg,game dev,0", "rpg,government,0", "rpg,hacking,3", "rpg,history,5", "rpg,horror,5", "rpg,hospital,5", "rpg,hunting,7", "rpg,law,7", "rpg,life,7", "rpg,martial arts,10", "rpg,medieval,10", "rpg,military,5", "rpg,movies,0", "rpg,music,0", "rpg,mystery,10", "rpg,ninja,5", "rpg,pirate,7", "rpg,post apocalyptic,10", "rpg,prison,5", "rpg,racing,5", "rpg,rhythm,3", "rpg,romance,5", "rpg,school,10", "rpg,sci-fi,10", "rpg,space,0", "rpg,sports,0", "rpg,spy,10", "rpg,superheroes,7", "rpg,surgery,0", "rpg,time travel,10", "rpg,transport,0", "rpg,ufo,0", "rpg,vampire,10", "rpg,virtual pet,7", "rpg,vocabulary,0", "rpg,werewolf,10", "rpg,wild west,10", "rpg,zombies,0", "simulation,airplane,10", "simulation,aliens,0", "simulation,alternate history,5", "simulation,business,10", "simulation,city,10", "simulation,comedy,0", "simulation,cyberpunk,5", "simulation,dance,10", "simulation,detective,5", "simulation,dungeon,10", "simulation,evolution,10", "simulation,fantasy,5", "simulation,fashion,10", "simulation,game dev,10", "simulation,government,10", "simulation,hacking,10", "simulation,history,10", "simulation,horror,0", "simulation,hospital,10", "simulation,hunting,10", "simulation,law,7", "simulation,life,10", "simulation,martial arts,10", "simulation,medieval,5", "simulation,military,10", "simulation,movies,10", "simulation,music,10", "simulation,mystery,5", "simulation,ninja,0", "simulation,pirate,7", "simulation,post apocalyptic,0", "simulation,prison,10", "simulation,racing,10", "simulation,rhythm,10", "simulation,romance,7", "simulation,school,10", "simulation,sci-fi,10", "simulation,space,10", "simulation,sports,10", "simulation,spy,5", "simulation,superheroes,0", "simulation,surgery,10", "simulation,time travel,3", "simulation,transport,10", "simulation,ufo,5", "simulation,vampire,0", "simulation,virtual pet,10", "simulation,vocabulary,10", "simulation,werewolf,0", "simulation,wild west,0", "simulation,zombies,0", "strategy,airplane,10", "strategy,aliens,7", "strategy,alternate history,7", "strategy,business,10", "strategy,city,10", "strategy,comedy,0", "strategy,cyberpunk,3", "strategy,dance,0", "strategy,detective,0", "strategy,dungeon,10", "strategy,evolution,10", "strategy,fantasy,10", "strategy,fashion,0", "strategy,game dev,0", "strategy,government,10", "strategy,hacking,10", "strategy,history,10", "strategy,horror,3", "strategy,hospital,5", "strategy,hunting,3", "strategy,law,7", "strategy,life,0", "strategy,martial arts,3", "strategy,medieval,10", "strategy,military,10", "strategy,movies,0", "strategy,music,0", "strategy,mystery,0", "strategy,ninja,5", "strategy,pirate,3", "strategy,post apocalyptic,7", "strategy,prison,5", "strategy,racing,3", "strategy,rhythm,0", "strategy,romance,0", "strategy,school,10", "strategy,sci-fi,10", "strategy,space,10", "strategy,sports,3", "strategy,spy,3", "strategy,superheroes,0", "strategy,surgery,3", "strategy,time travel,0", "strategy,transport,10", "strategy,ufo,10", "strategy,vampire,0", "strategy,virtual pet,7", "strategy,vocabulary,10", "strategy,werewolf,0", "strategy,wild west,0", "strategy,zombies,7", "", "", "casual,airplane,10", "casual,aliens,3", "casual,alternate history,0", "casual,business,0", "casual,city,3", "casual,comedy,10", "casual,cyberpunk,0", "casual,dance,10", "casual,detective,7", "casual,dungeon,0", "casual,evolution,0", "casual,fantasy,0", "casual,fashion,10", "casual,game dev,5", "casual,government,3", "casual,hacking,0", "casual,history,7", "casual,horror,5", "casual,hospital,3", "casual,hunting,7", "casual,law,0", "casual,life,5", "casual,martial arts,10", "casual,medieval,3", "casual,military,0", "casual,movies,10", "casual,music,10", "casual,mystery,5", "casual,ninja,7", "casual,pirate,5", "casual,post apocalyptic,0", "casual,prison,0", "casual,racing,10", "casual,rhythm,10", "casual,romance,7", "casual,school,5", "casual,sci-fi,5", "casual,space,3", "casual,sports,10", "casual,spy,5", "casual,superheroes,3", "casual,surgery,0", "casual,time travel,3", "casual,transport,0", "casual,ufo,5", "casual,vampire,3", "casual,virtual pet,10", "casual,vocabulary,10", "casual,werewolf,3", "casual,wild west,3", "casual,zombies,10"};
        string[] sliderThings = {"action,gameplay,7", "action,lore,3", "action,graphics,10", "adventure,gameplay,5", "adventure,lore,10", "adventure,graphics,7", "rpg,gameplay,5", "rpg,lore,10", "rpg,graphics,7", "simulation,gameplay,10", "simulation,lore,5", "simulation,graphics,7", "strategy,gameplay,10", "strategy,lore,5", "strategy,graphics,5", "casual,gameplay,10", "casual,lore,0", "casual,graphics,5"};
        #endregion

        int thisThemeGenreCombination = int.Parse(Array.Find(themeGenreCombinations, trash => trash.StartsWith(
            Global.GameNewProduct.Genre + "," + Global.GameNewProduct.Theme
        )).Split(",")[2]);

        int thisLoreSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.GameNewProduct.Genre + ",gameplay"
        )).Split(",")[2]);

        int thisStorytellingSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.GameNewProduct.Genre + ",lore"
        )).Split(",")[2]);

        int thisCharacterSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.GameNewProduct.Genre + ",graphics"
        )).Split(",")[2]);

        GD.Print(GetNode<HSlider>("../Slider1").Value);
        GD.Print(GetNode<HSlider>("../Slider2").Value);
        GD.Print(GetNode<HSlider>("../Slider3").Value);

        Global.GameNewProduct.Gameplay = (int)GetNode<HSlider>("../Slider1").Value/10;
        Global.GameNewProduct.Lore = (int)GetNode<HSlider>("../Slider2").Value/10;
        Global.GameNewProduct.Graphics = (int)GetNode<HSlider>("../Slider3").Value/10;
        int sliderThingy = 0;

        // how close the chosen slider value is to the ideal number
        switch (Math.Abs(Global.GameNewProduct.Gameplay-(int)Math.Round((decimal)thisLoreSlider))) {
            case 0: sliderThingy += 10; break;
            case 1: sliderThingy += 9; break;
            case 2: sliderThingy += 8; break;
            case 3: sliderThingy += 7; break;
            case 4: sliderThingy += 6; break;
            case 5: sliderThingy += 5; break;
            case 6: sliderThingy += 4; break;
            case 7: sliderThingy += 3; break;
            case 8: sliderThingy += 2; break;
            case 9: sliderThingy += 1; break;
            case 10: sliderThingy += 0; break;
        }

        switch (Math.Abs(Global.GameNewProduct.Lore-(int)Math.Round((decimal)thisStorytellingSlider))) {
            case 0: sliderThingy += 10; break;
            case 1: sliderThingy += 9; break;
            case 2: sliderThingy += 8; break;
            case 3: sliderThingy += 7; break;
            case 4: sliderThingy += 6; break;
            case 5: sliderThingy += 5; break;
            case 6: sliderThingy += 4; break;
            case 7: sliderThingy += 3; break;
            case 8: sliderThingy += 2; break;
            case 9: sliderThingy += 1; break;
            case 10: sliderThingy += 0; break;
        }

        switch (Math.Abs(Global.GameNewProduct.Graphics-(int)Math.Round((decimal)thisCharacterSlider))) {
            case 0: sliderThingy += 10; break;
            case 1: sliderThingy += 9; break;
            case 2: sliderThingy += 8; break;
            case 3: sliderThingy += 7; break;
            case 4: sliderThingy += 6; break;
            case 5: sliderThingy += 5; break;
            case 6: sliderThingy += 4; break;
            case 7: sliderThingy += 3; break;
            case 8: sliderThingy += 2; break;
            case 9: sliderThingy += 1; break;
            case 10: sliderThingy += 0; break;
        }

        // the final rating
        Global.GameNewProduct.Rating = (int)Math.Round((decimal)thisThemeGenreCombination/2) +
            (int)Math.Round((decimal)sliderThingy/6);
        
        Global.GameNewProduct.ThemeGenreCombination = thisThemeGenreCombination;

        Global.GameNewProduct.Type = "game";
        Global.GameNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.Money -= Global.GameNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.GameNewProduct;
        Global.DevelopingName = Global.GameNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
