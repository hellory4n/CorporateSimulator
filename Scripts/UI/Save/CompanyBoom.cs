using Godot;
using System;
using Newtonsoft.Json;

public class CompanyBoom : TextureButton {
    [Export]
    int CompanyNumber;

    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
        string gameFile = $"user://game{CompanyNumber}.json";
        File file = new File();
        if (file.FileExists(gameFile)) {
            file.Open(gameFile, File.ModeFlags.Read);
            GetNode<Label>("Label").Text = JsonConvert.DeserializeObject<GameSave>(
                file.GetAsText()
            ).Name;
            file.Close();
        } else {
            QueueFree(); // we can't delete a company that doesn't exist :)
        }
    }

    public void Click() {
        GetNode<Node2D>("../../../Boom").Visible = true;
        Global.CompanyThatWillSoonExplode = $"user://game{CompanyNumber}.json";
    }
}
