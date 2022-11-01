using Godot;
using System;

public class IndustryList : ItemList {
    public override void _Process(float delta) {
        if (GetSelectedItems().Length > 0)
            Global.NewCompanyDialogIndustryIndex = GetSelectedItems()[0];

        base._Process(delta);
    }
}
