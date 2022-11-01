using Godot;
using System;
using Newtonsoft.Json;

public class LoadGame : TextureButton {
    [Export]
    public string gameFile;
    public bool makeNewGame = false;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        // Show company names
        // I wanted to do something smarter but it failed
        File file = new File();
        if (file.FileExists(gameFile)) {
            file.Open(gameFile, File.ModeFlags.Read);
            GetNode<Label>("Label").Text = JsonConvert.DeserializeObject<GameSave>(
                file.GetAsText()
            ).Name;
            file.Close();
        } else {
            makeNewGame = true;
        }
    }

    public void Click() {
        if (GetNodeOrNull("/root/Game") != null) {
            Node ben = GetNode("/root/Game");
            ben.QueueFree();
            ben.Name = "jkolskjhgjlkrjjhekol";
        }

        // was this save menu created by the new game dialog?
        if (Global.SavesMenuFromNewGame) {
            Savior.NewGame(gameFile, Global.NewGameSave);
            Global.NewGameSave = null;
            Global.SavesMenuFromNewGame = false;

            PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
            Game game_ = (Game)game.Instance();
            game_.Name = "Game";
            game_.Init(gameFile);
            GetTree().Root.AddChild(game_);
        
        } else {
            // load save or open the new game dialog
            if (!makeNewGame) {
                PackedScene game = (PackedScene)ResourceLoader.Load("res://Scenes/Level1.tscn");
                Game game_ = (Game)game.Instance();
                game_.Name = "Game";
                game_.Init(gameFile);
                GetTree().Root.AddChild(game_);
            } else {
                PackedScene newGame_ = (PackedScene)ResourceLoader.Load("res://Scenes/NewCompany.tscn");
                Node2D newGame = (Node2D)newGame_.Instance();
                GetTree().Root.AddChild(newGame);
            }
        }

        // this button is inside a control node
        GetParent().GetParent().QueueFree();
    }
}
