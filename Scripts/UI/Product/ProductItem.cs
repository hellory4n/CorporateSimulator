using Godot;
using System;

public class ProductItem : Control {
    Product productProduct;

    public void Init(Product product_) {
        productProduct = product_;
    }

    public override void _Ready() {
        if (productProduct is SpaceProduct spaceProduct) {
            GetNode<Label>("ProductName").Text = productProduct.Name;
            if (productProduct.MoneySpent > productProduct.MoneyGot)
                GetNode<Label>("ProductInfo").Text = "Loss: $"+String.Format("{0:n0}",
                    productProduct.MoneySpent-productProduct.MoneyGot);
                else {
                    GetNode<Label>("ProductInfo").Text = "Profit: $"+String.Format("{0:n0}",
                        productProduct.MoneyGot-productProduct.MoneySpent);
                }
            
            GetNode<Label>("ProductInfo").Text = "Revenue: $" + String.Format("{0:n0}",
                productProduct.MoneyGot) + "\nSales: $" + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "Rating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just space stuff
                "\nCarrying: " + spaceProduct.Carrying + "\nPeople: " + spaceProduct.People +
                "\nDestination: " + spaceProduct.Destination + "\nSpeed: " + spaceProduct.Speed +
                "%\nFuel: " + spaceProduct.Fuel + "\nSafety: " + spaceProduct.Safety + "%";
                
            GetNode<Label>("ProductName").SetGlobalPosition(new Vector2(RectPosition.x, 29));
        }
    }
}
