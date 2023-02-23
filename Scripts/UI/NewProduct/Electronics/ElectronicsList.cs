using Godot;
using System;

public class ElectronicsList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/ElectronicsTypeButton.tscn");
        
        var OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Fridge");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Oven");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Microwave");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Toaster");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Washing machine");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Dishwasher");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Air conditioner");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Radiator");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Coffee maker");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Kettle");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Blender");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Mixer");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Vacuum cleaner");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("Electric fan");
        AddChild(OK);

        OK = (ElectronicsTypeButton)yes.Instance();
        OK.Init("TV");
        AddChild(OK);

        base._Ready();
    }
}
