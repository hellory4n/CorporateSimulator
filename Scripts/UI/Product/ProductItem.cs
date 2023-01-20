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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just book stuff
                "\nTheme: " + bookProduct.Theme + "\nGenre: " + bookProduct.Genre +
                "\nTheme/Genre combination: " + (int)bookProduct.ThemeGenreCombination + "/10\nLore: " +
                bookProduct.Lore*10 + "%\nStorytelling: " + bookProduct.Storytelling*10 + "%\nCharacters: " +
                bookProduct.Characters*10 + "%";
        }
        if (productProduct.Type == "medical") {
            // sorry
            GD.Print(objectProduct.ToString());
            MedicalProduct medicalProduct = JsonConvert.DeserializeObject<MedicalProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just medical stuff
                "\nAccuracy: " + medicalProduct.Accuracy + "%\nMarketing: " + medicalProduct.Marketing +
                "%";
        }
        if (productProduct.Type == "computer") {
            // sorry
            GD.Print(objectProduct.ToString());
            ComputerProduct computerProduct = JsonConvert.DeserializeObject<ComputerProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just computer stuff
                "\nPrice: $" + String.Format("{0:n0}", computerProduct.Price) + "\nCPU: " +
                computerProduct.Cpu.Split(",")[0] + " " + computerProduct.Cpu.Split(",")[1] +
                "\nGPU: " + computerProduct.Gpu.Split(",")[0] + " " + computerProduct.Gpu
                .Split(",")[1] + "\nRAM: " + computerProduct.Ram.Split(",")[0] + " GB\nStorage: " +
                computerProduct.Storage.Split(",")[1] + " GB " + computerProduct.Storage
                .Split(",")[0] + "\nOS: " + computerProduct.Os.Split(",")[0] + " " + computerProduct
                .Os.Split(",")[1];
        }
        if (productProduct.Type == "music") {
            // sorry
            GD.Print(objectProduct.ToString());
            MusicProduct musicProduct = JsonConvert.DeserializeObject<MusicProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just music stuff
                "\nSpeed: " + musicProduct.Speed + "%\nMelody: " + musicProduct.Melody +
                "%\nInstruments: " + musicProduct.Instruments + "%";
        }
        if (productProduct.Type == "media") {
            // sorry
            GD.Print(objectProduct.ToString());
            MediaProduct mediaProduct = JsonConvert.DeserializeObject<MediaProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just media stuff
                "\nTheme: " + mediaProduct.Theme + "\nGenre: " + mediaProduct.Genre +
                "\nTheme/Genre combination: " + (int)mediaProduct.ThemeGenreCombination + "/10\nLore: " +
                mediaProduct.Lore*10 + "%\nStorytelling: " + mediaProduct.Storytelling*10 + "%\nCharacters: " +
                mediaProduct.Characters*10 + "%";
        }
        if (productProduct.Type == "food") {
            // sorry
            GD.Print(objectProduct.ToString());
            FoodProduct foodProduct = JsonConvert.DeserializeObject<FoodProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just food stuff
                "\nNutritional value: " + foodProduct.NutritionalValue + "%\nTaste: " + foodProduct.Taste +
                "%";
        }
        if (productProduct.Type == "tv") {
            // sorry
            GD.Print(objectProduct.ToString());
            TvProduct tvProduct = JsonConvert.DeserializeObject<TvProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just tv stuff
                "\nType: " + tvProduct.TvType + "\nProduction time: " + tvProduct.ProductionTime +
                "%\nScript: " + tvProduct.Script + "%\nAds: " + tvProduct.Ads + "%";
        }
        if (productProduct.Type == "electronics") {
            // sorry
            GD.Print(objectProduct.ToString());
            ElectronicsProduct electronicsProduct = JsonConvert.DeserializeObject<ElectronicsProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just toaster stuff
                "\nFeatures: " + electronicsProduct.Features + "%\nSecurity: " + electronicsProduct.
                Security + "%\nIoT-ness: " + electronicsProduct.IoTNess + "%";
        }
        if (productProduct.Type == "apps") {
            // sorry
            GD.Print(objectProduct.ToString());
            AppProduct appProduct = JsonConvert.DeserializeObject<AppProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just app stuff
                "\nType: " + appProduct.AppType + "\nAlgorithm: " + appProduct.Algorithm +
                "%\nFeatures: " + appProduct.Features + "%\nInnovation: " + appProduct.Innovation + "%";
        }
        if (productProduct.Type == "phone") {
            // sorry
            GD.Print(objectProduct.ToString());
            PhoneProduct phoneProduct = JsonConvert.DeserializeObject<PhoneProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just computer stuff
                "\nPrice: $" + String.Format("{0:n0}", phoneProduct.Price) + "\nSoC: " +
                phoneProduct.Soc.Split(",")[0] + " " + phoneProduct.Soc.Split(",")[1] +
                "\nSize: " + phoneProduct.Size.Split(",")[0] + "\"\nRAM: " +
                phoneProduct.Ram.Split(",")[0] + " GB\nStorage: " + phoneProduct.Storage
                .Split(",")[0] + " GB\nBattery: " + phoneProduct.Battery.Split(",")[0] + "h";
        }
        if (productProduct.Type == "yourarse") {
            // sorry
            GD.Print(objectProduct.ToString());
            YourArseProduct yourArseProduct = JsonConvert.DeserializeObject<YourArseProduct>(
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
                productProduct.MoneyGot) + "\nSales: " + String.Format("{0:n0}", productProduct.Sales) +
                "\nCost: $" + String.Format("{0:n0}", productProduct.MoneySpent) + "\nRating: " +
                productProduct.Rating + "/10\nRelease date: " + productProduct.ReleaseDate +
                // just yourarse stuff
                "\nType: " + yourArseProduct.VideoType + "\nProduction time: " + yourArseProduct.
                ProductionTime + "%\nScript: " + yourArseProduct.Script + "%\nAds: " +
                yourArseProduct.Ads + "%";
        }
    }
}
