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
        // microsoft why do i always need to break cases - NOTE FROM THE FUTURE: skill issues
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
            case 12: newGame.Industries = new string[]{"games"}; break;
        }
        newGame.Name = GetNode<LineEdit>("../CompanyName").Text;
        newGame.Ceo = GetNode<LineEdit>("../CeoName").Text;
        newGame.MoneyHistory.Add(50000);

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
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Audiobooks", 50),
                    new ResearchSave("Merchandise", 50),
                    new ResearchSave("Localization", 50),
                    new ResearchSave("E-books", 50),
                    new ResearchSave("Images", 50),
                    new ResearchSave("Bible-sized books", 50),
                    new ResearchSave("Majestic lore", 50),
                    new ResearchSave("A different font", 50),
                    new ResearchSave("Awesome covers", 50),
                    new ResearchSave("Book-themed reading glasses", 500),
                });
                break;
            case "clothes":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Shiny clothes", 100)
                );
                break;
            case "apps":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Subscriptions", 50),
                    new ResearchSave("Advertisements", 50),
                    new ResearchSave("Endless notifications", 50),
                    new ResearchSave("In-app purchases", 50),
                    new ResearchSave("AI", 50),
                    new ResearchSave("Accessibility", 50),
                    new ResearchSave("Localization", 50),
                    new ResearchSave("Cross-platform compatibility", 50),
                    new ResearchSave("Better performance", 50),
                    new ResearchSave("Ultimate tracking", 50),
                });
                break;
            case "music":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Better sound quality", 50),
                    new ResearchSave("Music videos", 50),
                    new ResearchSave("Cooler instruments", 50),
                    new ResearchSave("Live performance", 50),
                    new ResearchSave("Sampling", 50),
                    new ResearchSave("Epic lyrics", 50),
                    new ResearchSave("Physical copies", 50),
                    new ResearchSave("Licensing", 50),
                    new ResearchSave("Copyright troll", 50),
                    new ResearchSave("Insanely long music", 50),
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
                    new ResearchSave("Localization", 50),
                    new ResearchSave("Subtitles", 50),
                    new ResearchSave("Interactive shows", 50),
                    new ResearchSave("Animation", 50),
                    new ResearchSave("Epic sounds", 50),
                    new ResearchSave("Mini-series", 50),
                    new ResearchSave("Spin-offs", 50),
                    new ResearchSave("Misinformation", 50),
                    new ResearchSave("Negativity bias", 50),
                    new ResearchSave("Live shows", 50),
                });
                break;
            case "electronics":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Energy efficiency", 50),
                    new ResearchSave("Smart home integration", 50),
                    new ResearchSave("More environmental impact", 50),
                    new ResearchSave("Voice control", 50),
                    new ResearchSave("Remote monitoring", 50),
                    new ResearchSave("Interdimensional encryption", 50),
                    new ResearchSave("Espionage", 50),
                    new ResearchSave("AI", 50),
                    new ResearchSave("Random sensors", 50),
                    new ResearchSave("Cloud connectivity", 50),
                });
                break;
            case "weapons":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Mass destruction", 1000)
                );
                break;
            case "phones":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("AI", 50),
                    new ResearchSave("6.9G compatibility", 50),
                    new ResearchSave("Better durability", 50),
                    new ResearchSave("Accessibility", 50),
                    new ResearchSave("Bloatware", 50),
                    new ResearchSave("Wireless charging", 50),
                    new ResearchSave("Water resistance", 50),
                    new ResearchSave("Augmented reality", 50),
                    new ResearchSave("Custom UI", 50),
                    new ResearchSave("Next-level notch", 50),
                });
                break;
            case "yourarse":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Epic editing", 50),
                    new ResearchSave("Majestic thumbnails", 50),
                    new ResearchSave("Subtitles", 50),
                    new ResearchSave("Obnoxiously long videos", 50),
                    new ResearchSave("Clickbait", 50),
                    new ResearchSave("Fantastic music", 50),
                    new ResearchSave("Sponsorships", 50),
                    new ResearchSave("OurTube Shorts", 50),
                    new ResearchSave("SEO optimization", 50),
                    new ResearchSave("Merchandise", 50),
                });
                break;
            case "food":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("High quality ingredients", 50),
                    new ResearchSave("Vegan food", 50),
                    new ResearchSave("Microwave food", 50),
                    new ResearchSave("Diet food", 50),
                    new ResearchSave("Garbage food", 50),
                    new ResearchSave("Food that lasts forever", 50),
                    new ResearchSave("Seasonal menus", 50),
                    new ResearchSave("Food delivery", 50),
                    new ResearchSave("Foreign cuisine", 50),
                    new ResearchSave("Peak food safety", 50),
                });
                break;
            case "medical":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Clinical trials", 50),
                    new ResearchSave("Telemedicine", 50),
                    new ResearchSave("Medical software", 50),
                    new ResearchSave("Hospitals", 50),
                    new ResearchSave("Vaccines", 50),
                    new ResearchSave("Nanotechnology", 50),
                    new ResearchSave("Quality control", 50),
                    new ResearchSave("Personalized medicine", 50),
                    new ResearchSave("Alternative therapy", 50),
                    new ResearchSave("Fake medicine", 50),
                });
                break;
            case "computers":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("RGB lights", 50),
                    new ResearchSave("Energy effiency", 50),
                    new ResearchSave("Better cooling", 50),
                    new ResearchSave("Better durability", 50),
                    new ResearchSave("Noise reduction", 50),
                    new ResearchSave("Custom mouse and keyboard", 50),
                    new ResearchSave("Custom monitors", 50),
                    new ResearchSave("Upgradability", 50),
                    new ResearchSave("Thinner laptops", 50),
                    new ResearchSave("Bloatware", 50),
                });
                break;
            case "restaurants":
                newGame.UnlockedResearch.Add(
                    new ResearchSave("Custom food", 50)
                );
                break;
            case "media":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Famous actors", 50),
                    new ResearchSave("Epic visual effects", 50),
                    new ResearchSave("Majestic lore", 50),
                    new ResearchSave("Diversity and inclusion", 50),
                    new ResearchSave("Fantastic soundtrack", 50),
                    new ResearchSave("Awesome CGI", 50),
                    new ResearchSave("Epic camera", 50),
                    new ResearchSave("Epic sound effects", 50),
                    new ResearchSave("Obnoxiously long movies", 50),
                    new ResearchSave("3D technology", 50),
                });
                break;
            case "games":
                newGame.UnlockedResearch.AddRange(new List<ResearchSave>(){
                    new ResearchSave("Epic lore", 50),
                    new ResearchSave("Mobile games", 50),
                    new ResearchSave("Localization", 50),
                    new ResearchSave("VR", 50),
                    new ResearchSave("Multiplayer", 50),
                    new ResearchSave("Majestic game engines", 50),
                    new ResearchSave("User generated content", 50),
                    new ResearchSave("Better user experience", 50),
                    new ResearchSave("Epic sounds", 50),
                    new ResearchSave("MMOs", 200),
                });
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