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
                    new ResearchSave("Go to other planets", 1000),
                    new ResearchSave("Terraforming", 5000),
                    new ResearchSave("Rocket booster V1", 500),
                    new ResearchSave("Rocket booster V2", 1000),
                    new ResearchSave("Rocket booster V3", 2000)
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
                    new ResearchSave("Servers", 50),
                    new ResearchSave("Games", 10),
                    new ResearchSave("Algorithms", 50),
                    new ResearchSave("Tracking V1", 50),
                    new ResearchSave("Tracking V2", 100),
                    new ResearchSave("Tracking V3", 200)
                });
                break;
            case "music":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Less piracy V1", 50),
                    new ResearchSave("Less piracy V2", 100),
                    new ResearchSave("Less piracy V3", 200)
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
                newGame.UnlockedResearch.Add(
                    new ResearchSave("4K", 50)
                );
                break;
            case "electronics":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("IoT V2", 100)
                );
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
                    new ResearchSave("Sponsorships", 50)
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
                    new ResearchSave("Custom OS", 100)
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

        GetParent().QueueFree();
    }
}