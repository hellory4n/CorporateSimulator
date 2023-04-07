using Godot;
using System;

public class PublicRelations : Label {
    public override void _Ready() {
        #region good reviews
        string[] goodReviews = new string[]{
            "good",
            "awesome",
            "majestic"
        };
        #endregion

        #region bad reviews
        string[] badReviews = new string[]{
            "bad",
            "sheet",
            "caca",
            "doesn't have eggs"
        };
        #endregion

        int badReviewAmount = 10-(int)Global.Reputation/10;
        Random soRandom = new Random();
        GD.Print(badReviewAmount);

        for (int i = 0; i < 9; i++) {
            if (i > badReviewAmount-1) {
                Text += goodReviews[soRandom.Next(0,goodReviews.Length)];
            } else {
                Text += badReviews[soRandom.Next(0,badReviews.Length)];
            }

            if (i < 8)
                Text += "\n";
        }
        base._Ready();
    }
}
