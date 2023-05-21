using Godot;
using System;
using System.Collections.Generic;

public class Statistics : Line2D {
    public float graphWidth = 870f;  // Width of the graph area
    public float graphHeight = 367f; // Height of the graph area

    public override void _Ready() {
        if (Global.MoneyHistory.Count < 2) {
            GetNode<Sprite>("../Sprite").QueueFree();
            Label bruh = GetNode<Label>("../Label2");
            bruh.RectSize = new Vector2(890,426);
            bruh.RectPosition = new Vector2(195,139);
            bruh.Text = "Please wait until Y1 M2 W1 to see statistics.";
            return;
        }

        float xStep = graphWidth / (Global.MoneyHistory.Count - 1);
        float yRange = GetMaxValue() - GetMinValue();

        for (int i = 1; i < Global.MoneyHistory.Count; i++) {
            float x1 = (i - 1) * xStep;
            float y1 = graphHeight - (Global.MoneyHistory[i - 1] - GetMinValue()) / yRange * graphHeight;

            float x2 = i * xStep;
            float y2 = graphHeight - (Global.MoneyHistory[i] - GetMinValue()) / yRange * graphHeight;

            AddPoint(new Vector2(x1, y1), i-1);
            AddPoint(new Vector2(x2, y2), i);
        }
    }

    private float GetMinValue() {
        float minValue = Global.MoneyHistory[0];
        foreach (float value in Global.MoneyHistory) {
            if (value < minValue)
                minValue = value;
        }
        return minValue;
    }

    private float GetMaxValue() {
        float maxValue = Global.MoneyHistory[0];
        foreach (float value in Global.MoneyHistory) {
            if (value > maxValue)
                maxValue = value;
        }
        return maxValue;
    }
}
