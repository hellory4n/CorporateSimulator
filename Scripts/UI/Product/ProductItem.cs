using Godot;
using System;
using Newtonsoft.Json;

public class ProductItem : Control {
    Product productProduct;
    object objectProduct;

    public void Init(Product product_, object objectProduct_) {
        productProduct = product_;
        objectProduct = objectProduct_;
    }

    public override void _Ready() {
        if (productProduct.Type == "rocket") {
            // sorry
            SpaceProduct spaceProduct = JsonConvert.DeserializeObject<SpaceProduct>(
                JsonConvert.SerializeObject(objectProduct));
            GetNode<Label>("ProductName").Text = productProduct.Name;
            if (productProduct.MoneySpent > productProduct.MoneyGot)
                GetNode<Label>("ProductInfo").Text = "Loss: $"+String.Format("{0:n0}",
                    productProduct.MoneySpent-productProduct.MoneyGot);
                else {
                    GetNode<Label>("ProductInfo").Text = "Profit: $"+String.Format("{0:n0}",
                        productProduct.MoneyGot-productProduct.MoneySpent);
                }
            
            GetNode<Label>("ProductInfo").Text += "\nRevenue: $" + String.Format("{0:n0}",
                productProduct.MoneyGot) + "\nSales: $" + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just space stuff
                "\nCarrying: " + spaceProduct.Carrying + "\nPeople: " + spaceProduct.People +
                "\nDestination: " + spaceProduct.Destination + "\nSpeed: " + spaceProduct.Speed +
                "%\nFuel: " + spaceProduct.Fuel + "\nSafety: " + spaceProduct.Safety + "%";
        }
        if (productProduct.Type == "book") {
            // sorry
            GD.Print(objectProduct.ToString());
            BookProduct bookProduct = JsonConvert.DeserializeObject<BookProduct>(
                JsonConvert.SerializeObject(objectProduct));
            GetNode<Label>("ProductName").Text = productProduct.Name;
            if (productProduct.MoneySpent > productProduct.MoneyGot)
                GetNode<Label>("ProductInfo").Text = "Loss: $"+String.Format("{0:n0}",
                    productProduct.MoneySpent-productProduct.MoneyGot);
                else {
                    GetNode<Label>("ProductInfo").Text = "Profit: $"+String.Format("{0:n0}",
                        productProduct.MoneyGot-productProduct.MoneySpent);
                }
            
            GetNode<Label>("ProductInfo").Text += "\nRevenue: $" + String.Format("{0:n0}",
                productProduct.MoneyGot) + "\nSales: $" + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just book stuff
                "\nTheme: " + bookProduct.Theme + "\nGenre: " + bookProduct.Genre +
                "\nTheme/Genre combination: " + (int)bookProduct.ThemeGenreCombination + "/10\nLore: " +
                bookProduct.Lore*10 + "%\nStorytelling: " + bookProduct.Storytelling*10 + "%\nCharacters: " +
                bookProduct.Characters*10 + "%";
        }
    }
}
