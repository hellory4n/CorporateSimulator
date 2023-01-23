using Godot;
using System;

public class Events : Node2D {
    public override void _Process(float delta) {
        #region Sales
        // we can't sell void
        if (Global.Products.Count > 0) {
            dynamic garbage = Global.Products[Global.Products.Count-1]; // hope this doesn't explode
            int price = 69420;
            double saleRate = 80;

            // garbage price
            if (garbage is ComputerProduct) {
                ComputerProduct shjksj = (ComputerProduct)garbage;
                price = shjksj.Price;
            } else if (garbage is TvProduct) {
                TvProduct hjskosp = (TvProduct)garbage;
                price = hjskosp.Ads;
            } else if (garbage is AppProduct) {
                AppProduct jskiops = (AppProduct)garbage;
                price = jskiops.Algorithm;
            } else if (garbage is PhoneProduct) {
                PhoneProduct hjsksjk = (PhoneProduct)garbage;
                price = hjsksjk.Price;
            } else if (garbage is YourArseProduct) {
                YourArseProduct sjksmg = (YourArseProduct)garbage;
                price = sjksmg.Ads;
            } else if (garbage is SpaceProduct) {
                price = 0; // space companies rely on investors
            } else {
                price = garbage.Rating*5;
            }

            saleRate -= Global.Reputation/100;
            saleRate -= Global.Investors/100000;
            saleRate -= Global.MarketingBudget/10000;

            if (saleRate < 0)
                saleRate = 0.1;

            if (Engine.GetIdleFrames() % (ulong)saleRate*60 == 0 && Global.PausedTime == false) {
                garbage.Sales += 100;
                garbage.MoneyGot += price*100;
                Global.Money += price*100;
                Global.Products[Global.Products.Count-1] = (object)garbage;
            }
        }
        #endregion
        base._Process(delta);
    }
}