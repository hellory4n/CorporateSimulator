using Godot;
using System;

public class FoodTypeList : VBoxContainer {
    public override void _Ready() {
        var yes = (PackedScene)ResourceLoader.Load("res://Scenes/NewProducts/FoodTypeButton.tscn");
        
        var OK = (FoodTypeButton)yes.Instance();
        OK.Init("Fruit");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Vegetables");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Meat");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Dairy");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Seafood");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Whole grains");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Refined grains");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Noodles");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Herbs");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Spices");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Appetizers");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Bread");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Candies");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Cakes");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Pies and tarts");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Pastries");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Cookies");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Frozen desserts");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Custards and puddings");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Dumplings");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Salad");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Soups and stews");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Snacks");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Sandwiches");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Fast food");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Fermented food");
        AddChild(OK);

        OK = (FoodTypeButton)yes.Instance();
        OK.Init("Dried food");
        AddChild(OK);

        base._Ready();
    }
}
