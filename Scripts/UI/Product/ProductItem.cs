using Godot;
using System;

public class ProductItem : Control {
    object product;
    object productProduct;

    public void Init(object product_) {
        product = product_;
    }

p     public override void _Ready() {
        Product productProduct = (Product)product;
        if (productProduct.Type == "space") {
            SpaceProduct spaceProduct = (SpaceProduct)productProduct;
            GetNode<Label>("ProductName").Text = productProduct.Name;
            if (productProduct.MoneySpent > productProduct.MoneyGot)
                GetNode<Label>("ProductInfo").Text = "Loss: $"+String.Format("{0:n0}",
                    productProduct.MoneySpent-productProduct.MoneyGot);
                else {
                    GetNode<Label>("ProductInfo").Text = "Profit: $"+String.Format("{0:n0}",
                        productProduct.MoneyGot-productProduct.MoneySpent);
                }

                GetNode<Label>("ProductInfo").Text += "Revenue: $" + String.Format("{0:n0}",
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
