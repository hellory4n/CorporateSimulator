using Godot;
using System;

public class ChinaTradeAgreement : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.China.Friendship > 74)
            Global.China.TradeAgreement = true;

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Government/ChinaTradeAgreement.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
