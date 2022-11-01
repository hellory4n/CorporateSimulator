using Godot;
using System;

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
            case 1: newGame.Industries = new string[]{"buildings"}; break;
            case 2: newGame.Industries = new string[]{"food"}; break;
            case 3: newGame.Industries = new string[]{"books"}; break;
            case 4: newGame.Industries = new string[]{"tv"}; break;
            case 5: newGame.Industries = new string[]{"medical"}; break;
            case 6: newGame.Industries = new string[]{"clothes"}; break;
            case 7: newGame.Industries = new string[]{"electronics"}; break;
            case 8: newGame.Industries = new string[]{"computers"}; break;
            case 9: newGame.Industries = new string[]{"apps"}; break;
            case 10: newGame.Industries = new string[]{"weapons"}; break;
            case 11: newGame.Industries = new string[]{"restaurants"}; break;
            case 12: newGame.Industries = new string[]{"music"}; break;
            case 13: newGame.Industries = new string[]{"phones"}; break;
            case 14: newGame.Industries = new string[]{"media"}; break;
            case 15: newGame.Industries = new string[]{"animation"}; break;
            case 16: newGame.Industries = new string[]{"yourarse"}; break;
        }
        newGame.Name = GetNode<LineEdit>("../CompanyName").Text;
        newGame.Ceo = GetNode<LineEdit>("../CeoName").Text;

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
