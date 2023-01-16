using Godot;
using System;

public class MediaFinish : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        // calculate rating
        #region i'm sorry
        string[] themeGenreCombinations = {"action and adventure,circle of life,7", "action and adventure,coming of age,9", "action and adventure,faith vs doubt,8", "action and adventure,family,7", "action and adventure,fate vs free will,9", "action and adventure,good vs evil,9", "action and adventure,hubris,8", "action and adventure,identity,9", "action and adventure,justice,9", "action and adventure,loneliness,0", "action and adventure,man vs nature,9", "action and adventure,man vs self,9", "action and adventure,man vs society,9", "action and adventure,power and corruption,7", "action and adventure,pursuit of love,1", "action and adventure,revenge,7", "action and adventure,sacrificial love,9", "action and adventure,survival,9", "action and adventure,the environment,5", "action and adventure,war,9", "classics,circle of life,10", "classics,coming of age,10", "classics,faith vs doubt,10", "classics,family,10", "classics,fate vs free will,10", "classics,good vs evil,10", "classics,hubris,10", "classics,identity,10", "classics,justice,10", "classics,loneliness,10", "classics,man vs nature,10", "classics,man vs self,10", "classics,man vs society,10", "classics,power and corruption,10", "classics,pursuit of love,10", "classics,revenge,10", "classics,sacrificial love,10", "classics,survival,10", "classics,the environment,10", "classics,war,10", "animation,circle of life,8", "animation,coming of age,8", "animation,faith vs doubt,8", "animation,family,8", "animation,fate vs free will,8", "animation,good vs evil,8", "animation,hubris,8", "animation,identity,8", "animation,justice,8", "animation,loneliness,8", "animation,man vs nature,8", "animation,man vs self,8", "animation,man vs society,8", "animation,power and corruption,8", "animation,pursuit of love,8", "animation,revenge,8", "animation,sacrificial love,8", "animation,survival,8", "animation,the environment,8", "animation,war,8", "detective and mystery,circle of life,5", "detective and mystery,coming of age,5", "detective and mystery,faith vs doubt,9", "detective and mystery,family,4", "detective and mystery,fate vs free will,5", "detective and mystery,good vs evil,9", "detective and mystery,hubris,2", "detective and mystery,identity,0", "detective and mystery,justice,9", "detective and mystery,loneliness,0", "detective and mystery,man vs nature,0", "detective and mystery,man vs self,0", "detective and mystery,man vs society,0", "detective and mystery,power and corruption,5", "detective and mystery,pursuit of love,0", "detective and mystery,revenge,1", "detective and mystery,sacrificial love,0", "detective and mystery,survival,0", "detective and mystery,the environment,0", "detective and mystery,war,0", "fantasy,circle of life,3", "fantasy,coming of age,1", "fantasy,faith vs doubt,7", "fantasy,family,9", "fantasy,fate vs free will,7", "fantasy,good vs evil,9", "fantasy,hubris,6", "fantasy,identity,3", "fantasy,justice,9", "fantasy,loneliness,0", "fantasy,man vs nature,7", "fantasy,man vs self,3", "fantasy,man vs society,0", "fantasy,power and corruption,7", "fantasy,pursuit of love,5", "fantasy,revenge,5", "fantasy,sacrificial love,5", "fantasy,survival,5", "fantasy,the environment,5", "fantasy,war,0", "historical fiction,circle of life,6", "historical fiction,coming of age,6", "historical fiction,faith vs doubt,7", "historical fiction,family,5", "historical fiction,fate vs free will,7", "historical fiction,good vs evil,5", "historical fiction,hubris,8", "historical fiction,identity,0", "historical fiction,justice,6", "historical fiction,loneliness,0", "historical fiction,man vs nature,9", "historical fiction,man vs self,0", "historical fiction,man vs society,7", "historical fiction,power and corruption,9", "historical fiction,pursuit of love,1", "historical fiction,revenge,9", "historical fiction,sacrificial love,6", "historical fiction,survival,7", "historical fiction,the environment,9", "historical fiction,war,9", "horror,circle of life,1", "horror,coming of age,2", "horror,faith vs doubt,5", "horror,family,0", "horror,fate vs free will,3", "horror,good vs evil,4", "horror,hubris,5", "horror,identity,0", "horror,justice,0", "horror,loneliness,6", "horror,man vs nature,2", "horror,man vs self,8", "horror,man vs society,3", "horror,power and corruption,0", "horror,pursuit of love,0", "horror,revenge,0", "horror,sacrificial love,0", "horror,survival,1", "horror,the environment,6", "horror,war,9", "literary fiction,circle of life,5", "literary fiction,coming of age,5", "literary fiction,faith vs doubt,5", "literary fiction,family,6", "literary fiction,fate vs free will,7", "literary fiction,good vs evil,8", "literary fiction,hubris,5", "literary fiction,identity,5", "literary fiction,justice,9", "literary fiction,loneliness,5", "literary fiction,man vs nature,9", "literary fiction,man vs self,9", "literary fiction,man vs society,9", "literary fiction,power and corruption,8", "literary fiction,pursuit of love,7", "literary fiction,revenge,5", "literary fiction,sacrificial love,9", "literary fiction,survival,5", "literary fiction,the environment,7", "literary fiction,war,5", "romance,circle of life,5", "romance,coming of age,4", "romance,faith vs doubt,3", "romance,family,0", "romance,fate vs free will,6", "romance,good vs evil,6", "romance,hubris,2", "romance,identity,2", "romance,justice,1", "romance,loneliness,0", "romance,man vs nature,0", "romance,man vs self,1", "romance,man vs society,0", "romance,power and corruption,0", "romance,pursuit of love,9", "romance,revenge,0", "romance,sacrificial love,9", "romance,survival,0", "romance,the environment,0", "romance,war,0", "science fiction,circle of life,4", "science fiction,coming of age,1", "science fiction,faith vs doubt,7", "science fiction,family,1", "science fiction,fate vs free will,4", "science fiction,good vs evil,7", "science fiction,hubris,7", "science fiction,identity,0", "science fiction,justice,0", "science fiction,loneliness,6", "science fiction,man vs nature,8", "science fiction,man vs self,0", "science fiction,man vs society,0", "science fiction,power and corruption,7", "science fiction,pursuit of love,0", "science fiction,revenge,0", "science fiction,sacrificial love,0", "science fiction,survival,9", "science fiction,the environment,9", "science fiction,war,9", "short,circle of life,9", "short,coming of age,9", "short,faith vs doubt,9", "short,family,9", "short,fate vs free will,9", "short,good vs evil,9", "short,hubris,9", "short,identity,9", "short,justice,9", "short,loneliness,9", "short,man vs nature,9", "short,man vs self,9", "short,man vs society,9", "short,power and corruption,9", "short,pursuit of love,9", "short,revenge,9", "short,sacrificial love,9", "short,survival,9", "short,the environment,9", "short,war,9", "suspense and thrillers,circle of life,1", "suspense and thrillers,coming of age,1", "suspense and thrillers,faith vs doubt,2", "suspense and thrillers,family,0", "suspense and thrillers,fate vs free will,3", "suspense and thrillers,good vs evil,6", "suspense and thrillers,hubris,4", "suspense and thrillers,identity,2", "suspense and thrillers,justice,5", "suspense and thrillers,loneliness,0", "suspense and thrillers,man vs nature,1", "suspense and thrillers,man vs self,7", "suspense and thrillers,man vs society,2", "suspense and thrillers,power and corruption,3", "suspense and thrillers,pursuit of love,0", "suspense and thrillers,revenge,9", "suspense and thrillers,sacrificial love,0", "suspense and thrillers,survival,8", "suspense and thrillers,the environment,7", "suspense and thrillers,war,3", "biographies,circle of life,0", "biographies,coming of age,9", "biographies,faith vs doubt,7", "biographies,family,9", "biographies,fate vs free will,6", "biographies,good vs evil,7", "biographies,hubris,4", "biographies,identity,9", "biographies,justice,9", "biographies,loneliness,7", "biographies,man vs nature,1", "biographies,man vs self,9", "biographies,man vs society,8", "biographies,power and corruption,8", "biographies,pursuit of love,9", "biographies,revenge,7", "biographies,sacrificial love,9", "biographies,survival,9", "biographies,the environment,0", "biographies,war,9", "comedy,circle of life,9", "comedy,coming of age,9", "comedy,faith vs doubt,9", "comedy,family,9", "comedy,fate vs free will,9", "comedy,good vs evil,9", "comedy,hubris,9", "comedy,identity,9", "comedy,justice,9", "comedy,loneliness,9", "comedy,man vs nature,9", "comedy,man vs self,9", "comedy,man vs society,9", "comedy,power and corruption,9", "comedy,pursuit of love,9", "comedy,revenge,9", "comedy,sacrificial love,9", "comedy,survival,9", "comedy,the environment,9", "comedy,war,9", "documentary,circle of life,1", "documentary,coming of age,7", "documentary,faith vs doubt,8", "documentary,family,8", "documentary,fate vs free will,7", "documentary,good vs evil,9", "documentary,hubris,9", "documentary,identity,9", "documentary,justice,9", "documentary,loneliness,9", "documentary,man vs nature,9", "documentary,man vs self,9", "documentary,man vs society,9", "documentary,power and corruption,9", "documentary,pursuit of love,7", "documentary,revenge,7", "documentary,sacrificial love,8", "documentary,survival,7", "documentary,the environment,9", "documentary,war,9", "history,circle of life,0", "history,coming of age,5", "history,faith vs doubt,8", "history,family,7", "history,fate vs free will,6", "history,good vs evil,7", "history,hubris,9", "history,identity,0", "history,justice,7", "history,loneliness,5", "history,man vs nature,7", "history,man vs self,7", "history,man vs society,0", "history,power and corruption,9", "history,pursuit of love,2", "history,revenge,9", "history,sacrificial love,0", "history,survival,4", "history,the environment,7", "history,war,9", "memoir,circle of life,5", "memoir,coming of age,9", "memoir,faith vs doubt,7", "memoir,family,7", "memoir,fate vs free will,7", "memoir,good vs evil,5", "memoir,hubris,7", "memoir,identity,9", "memoir,justice,8", "memoir,loneliness,6", "memoir,man vs nature,1", "memoir,man vs self,6", "memoir,man vs society,9", "memoir,power and corruption,9", "memoir,pursuit of love,9", "memoir,revenge,7", "memoir,sacrificial love,9", "memoir,survival,8", "memoir,the environment,0", "memoir,war,9", "poetry,circle of life,9", "poetry,coming of age,9", "poetry,faith vs doubt,9", "poetry,family,9", "poetry,fate vs free will,9", "poetry,good vs evil,9", "poetry,hubris,9", "poetry,identity,9", "poetry,justice,9", "poetry,loneliness,9", "poetry,man vs nature,9", "poetry,man vs self,9", "poetry,man vs society,9", "poetry,power and corruption,9", "poetry,pursuit of love,9", "poetry,revenge,9", "poetry,sacrificial love,9", "poetry,survival,9", "poetry,the environment,9", "poetry,war,9", "self-help,circle of life,4", "self-help,coming of age,0", "self-help,faith vs doubt,2", "self-help,family,1", "self-help,fate vs free will,3", "self-help,good vs evil,7", "self-help,hubris,2", "self-help,identity,9", "self-help,justice,1", "self-help,loneliness,9", "self-help,man vs nature,0", "self-help,man vs self,9", "self-help,man vs society,0", "self-help,power and corruption,1", "self-help,pursuit of love,6", "self-help,revenge,5", "self-help,sacrificial love,0", "self-help,survival,9", "self-help,the environment,0", "self-help,war,0", "true crime,circle of life,0", "true crime,coming of age,0", "true crime,faith vs doubt,5", "true crime,family,0", "true crime,fate vs free will,0", "true crime,good vs evil,9", "true crime,hubris,1", "true crime,identity,0", "true crime,justice,8", "true crime,loneliness,0", "true crime,man vs nature,0", "true crime,man vs self,0", "true crime,man vs society,1", "true crime,power and corruption,1", "true crime,pursuit of love,0", "true crime,revenge,9", "true crime,sacrificial love,0", "true crime,survival,5", "true crime,the environment,0", "true crime,war,0"};
        string[] sliderThings = {"action and adventure,lore,4", "action and adventure,storytelling,8", "action and adventure,characters,5", "classics,lore,5", "classics,storytelling,5", "classics,characters,5", "animation,lore,7", "animation,storytelling,8", "animation,characters,6", "detective and mystery,lore,10", "detective and mystery,storytelling,8", "detective and mystery,characters,5", "fantasy,lore,6", "fantasy,storytelling,9", "fantasy,characters,10", "historical fiction,lore,10", "historical fiction,storytelling,6", "historical fiction,characters,8", "horror,lore,3", "horror,storytelling,10", "horror,characters,3", "literary fiction,lore,9", "literary fiction,storytelling,8", "literary fiction,characters,7", "romance,lore,7", "romance,storytelling,9", "romance,characters,10", "science fiction,lore,10", "science fiction,storytelling,7", "science fiction,characters,6", "short,lore,2", "short,storytelling,10", "short,characters,2", "suspense and thrillers,lore,9", "suspense and thrillers,storytelling,10", "suspense and thrillers,characters,8", "biographies,lore,10", "biographies,storytelling,5", "biographies,characters,4", "comedy,lore,7", "comedy,storytelling,10", "comedy,characters,5", "documentary,lore,0", "documentary,storytelling,10", "documentary,characters,0", "history,lore,10", "history,storytelling,7", "history,characters,4", "memoir,lore,10", "memoir,storytelling,5", "memoir,characters,4", "poetry,lore,5", "poetry,storytelling,10", "poetry,characters,2", "self-help,lore,0", "self-help,storytelling,10", "self-help,characters,0", "true crime,lore,10", "true crime,storytelling,7", "true crime,characters,7"};
        #endregion

        int thisThemeGenreCombination = int.Parse(Array.Find(themeGenreCombinations, trash => trash.StartsWith(
            Global.MediaNewProduct.Genre + "," + Global.MediaNewProduct.Theme
        )).Split(",")[2]);

        int thisLoreSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.MediaNewProduct.Genre + ",lore"
        )).Split(",")[2]);

        int thisStorytellingSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.MediaNewProduct.Genre + ",storytelling"
        )).Split(",")[2]);

        int thisCharacterSlider = int.Parse(Array.Find(sliderThings, trash => trash.StartsWith(
            Global.MediaNewProduct.Genre + ",characters"
        )).Split(",")[2]);

        GD.Print(GetNode<HSlider>("../Slider1").Value);
        GD.Print(GetNode<HSlider>("../Slider2").Value);
        GD.Print(GetNode<HSlider>("../Slider3").Value);

        Global.MediaNewProduct.Lore = (int)GetNode<HSlider>("../Slider1").Value/10;
        Global.MediaNewProduct.Storytelling = (int)GetNode<HSlider>("../Slider2").Value/10;
        Global.MediaNewProduct.Characters = (int)GetNode<HSlider>("../Slider3").Value/10;
        int sliderThingy = 0;

        // how close the chosen slider value is to the ideal number
        switch (Math.Abs(Global.MediaNewProduct.Lore-(int)Math.Round((decimal)thisLoreSlider))) {
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

        switch (Math.Abs(Global.MediaNewProduct.Storytelling-(int)Math.Round((decimal)thisStorytellingSlider))) {
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

        switch (Math.Abs(Global.MediaNewProduct.Characters-(int)Math.Round((decimal)thisCharacterSlider))) {
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
        Global.MediaNewProduct.Rating = (int)Math.Round((decimal)thisThemeGenreCombination/2) +
            (int)Math.Round((decimal)sliderThingy/6);
        
        Global.MediaNewProduct.ThemeGenreCombination = thisThemeGenreCombination;

        Global.MediaNewProduct.Type = "media";
        Global.MediaNewProduct.ReleaseDate = "Y" + Global.Year + " M" + Global.Month + " W" + Global.Week;
        Global.Money -= Global.MediaNewProduct.MoneySpent;
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/Developing.tscn");
        Label OK = (Label)yes.Instance();
        OK.RectPosition = new Vector2(-25, 286);
        Global.Developing = Global.MediaNewProduct;
        Global.DevelopingName = Global.MediaNewProduct.Name;
        GetTree().Root.AddChild(OK);
        GetParent().QueueFree();
    }
}
