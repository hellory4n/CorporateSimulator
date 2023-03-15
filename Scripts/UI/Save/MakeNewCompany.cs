using Godot;
using System;
using System.Collections.Generic;

public class MakeNewCompany : TextureButton {
    public override void _Ready() {
        Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        GameSave newGame = new GameSave();
        // turn the index thing into a string
        // microsoft why do i always need to break cases
        switch (Global.NewCompanyDialogIndustryIndex) {
            case 0: newGame.Industries = new string[]{"space"}; break;
            case 1: newGame.Industries = new string[]{"food"}; break;
            case 2: newGame.Industries = new string[]{"books"}; break;
            case 3: newGame.Industries = new string[]{"tv"}; break;
            case 4: newGame.Industries = new string[]{"medical"}; break;
            case 5: newGame.Industries = new string[]{"electronics"}; break;
            case 6: newGame.Industries = new string[]{"computers"}; break;
            case 7: newGame.Industries = new string[]{"apps"}; break;
            case 8: newGame.Industries = new string[]{"music"}; break;
            case 9: newGame.Industries = new string[]{"phones"}; break;
            case 10: newGame.Industries = new string[]{"media"}; break;
            case 11: newGame.Industries = new string[]{"yourarse"}; break;
        }
        newGame.Name = GetNode<LineEdit>("../CompanyName").Text;
        newGame.Ceo = GetNode<LineEdit>("../CeoName").Text;

        #region unlocked research
        switch (newGame.Industries[0]) {
            case "space":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Satellites", 50),
                    new ResearchSave("People in space", 100),
                    new ResearchSave("Space station", 250),
                    new ResearchSave("Go to other planets", 500),
                    new ResearchSave("Terraforming", 1000),
                });
                break;
            case "books":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Giant books", 50)
                );
                break;
            case "clothes":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Shiny clothes", 100)
                );
                break;
            case "apps":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Algorithms Pro", 50),
                    new ResearchSave("Algorithms Pro Max", 100),
                    new ResearchSave("Algorithms Pro Max Ultra", 250),
                    new ResearchSave("Algorithms 2", 500),
                    new ResearchSave("Algorithms 2 Pro", 1000),
                    new ResearchSave("Algorithms 2 Pro Max", 2500),
                    new ResearchSave("Algorithms 2 Pro Max Ultra", 5000),
                });
                break;
            case "music":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Cooler Music", 50),
                });
                break;
            case "animation":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("2D V2", 100),
                    new ResearchSave("3D V1", 50),
                });
                break;
            case "buildings":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Skyscrapers", 100)
                );
                break;
            case "tv":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("4K", 50),
                    new ResearchSave("Ads Pro", 50),
                    new ResearchSave("Ads Pro Max", 100),
                    new ResearchSave("Ads Pro Max Ultra", 250),
                    new ResearchSave("Ads 2", 500),
                    new ResearchSave("Ads 2 Pro", 1000),
                    new ResearchSave("Ads 2 Pro Max", 2500),
                    new ResearchSave("Ads 2 Pro Max Ultra", 5000),
                });
                break;
            case "electronics":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("IoT Pro", 50),
                    new ResearchSave("IoT Pro Max", 100),
                    new ResearchSave("IoT Pro Max Ultra", 250),
                    new ResearchSave("IoT 2", 500),
                    new ResearchSave("IoT 2 Pro", 1000),
                    new ResearchSave("IoT 2 Pro Max", 2500),
                    new ResearchSave("IoT 2 Pro Max Ultra", 5000),
                });
                break;
            case "weapons":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Mass destruction", 1000)
                );
                break;
            case "phones":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("More screen V1", 50),
                    new ResearchSave("Gimmicks", 50),
                    new ResearchSave("Custom OS", 100)
                });
                break;
            case "yourarse":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("4K", 50)
                );
                break;
            case "food":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Magic", 100)
                );
                break;
            case "medical":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Magic", 100)
                );
                break;
            case "computers":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("RGB lights", 10),
                });
                break;
            case "restaurants":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Custom food", 50)
                );
                break;
            case "media":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Famous actors", 50)
                );
                break;
        }
        #endregion

        // we need to save this somewhere
        Global.NewGameSave = newGame;
        Global.SavesMenuFromNewGame = true;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Saves.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
        Global.DebtOno = 0;

        GetParent().QueueFree();
    }
}