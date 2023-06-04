using Godot;
using System;

public class UsaTradeAgreement : TextureButton {
    public override void _Ready() {
        this.Connect("pressed", this, nameof(Click));
    }

    public void Click() {
        if (Global.UnitedStates.Friendship > 74)
            Global.UnitedStates.TradeAgreement = true;

        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/Government/UsaTradeAgreement.tscn");
        Node2D OK = (Node2D)yes.Instance();
        OK.ZIndex = 100;
        GetTree().Root.AddChild(OK);
    }
}
