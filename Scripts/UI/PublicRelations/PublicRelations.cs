using Godot;
using System;

public class PublicRelations : Label {
    public override void _Ready() {
        #region good reviews
        string[] goodReviews = new string[]{
            $"{Global.CompanyName} provides exceptional customer service that is unmatched by its competitors.",
            $"I am always impressed with the high-quality products {Global.CompanyName} produces.",
            "Their dedication to sustainability is truly inspiring and sets them apart from others in their industry.",
            $"The employees at {Global.CompanyName} are friendly, knowledgeable, and always willing to help.",
            $"I appreciate the attention to detail that {Global.CompanyName} puts into every aspect of their business.",
            $"The user-friendly website makes shopping with {Global.CompanyName} a breeze.",
            $"{Global.CompanyName}'s commitment to community involvement is truly admirable.",
            "The prices are competitive, but the quality of their products is unbeatable.",
            $"{Global.CompanyName} consistently goes above and beyond to meet their customers' needs.",
            $"I am continually impressed with the innovation and creativity {Global.CompanyName} brings to their industry.",
            "Their strong ethics and values shine through in every aspect of their business.",
            $"The fast shipping and reliable delivery make {Global.CompanyName} a pleasure to do business with.",
            "Their products are always top-notch, and the packaging is both secure and visually appealing.",
            $"{Global.CompanyName}'s dedication to diversity and inclusion is commendable.",
            $"I appreciate the transparency {Global.CompanyName} provides regarding their manufacturing and sourcing practices.",
            $"{Global.CompanyName}'s philanthropic efforts and donations to charitable causes are truly impactful.",
            $"The customer reviews speak for themselves - {Global.CompanyName} consistently exceeds expectations.",
            $"{Global.CompanyName}'s commitment to producing eco-friendly products is both admirable and essential.",
            $"The ease of communication with {Global.CompanyName}'s customer service team is exceptional.",
            $"I highly recommend {Global.CompanyName} to anyone looking for high-quality products and excellent customer service."
        };
        #endregion

        #region bad reviews
        string[] badReviews = new string[]{
            $"The customer service at {Global.CompanyName} is consistently unhelpful and frustrating to deal with.",
            "The quality of their products is subpar and not worth the price.",
            $"I have had multiple negative experiences with {Global.CompanyName}'s shipping and delivery services.",
            $"{Global.CompanyName} has a poor reputation for ethical practices in their industry.",
            "Their website is confusing and difficult to navigate, making online shopping a hassle.",
            "The lack of diversity and inclusion within the company is concerning and unacceptable.",
            $"I have had issues with faulty products from {Global.CompanyName}, and their return process is a nightmare.",
            "Their marketing tactics are often misleading and deceptive.",
            $"{Global.CompanyName} has a history of exploiting their workers and paying them unfair wages.",
            "The wait times for customer service are extremely long and frustrating.",
            "Their products often arrive damaged due to inadequate packaging.",
            "I have experienced multiple billing errors from this company, leading to unnecessary headaches.",
            "The company's response to customer complaints and issues is often dismissive and unsatisfactory.",
            $"{Global.CompanyName} has a negative impact on the environment, with little effort to become more sustainable.",
            "The lack of transparency regarding their sourcing and manufacturing processes is concerning.",
            "Their prices are unjustifiably high, given the quality of their products and services.",
            $"The company culture at {Global.CompanyName} is toxic and unprofessional.",
            "I have had issues with canceled orders without proper explanation or compensation.",
            "The customer reviews are consistently negative, with numerous complaints about the company's practices.",
            $"I strongly advise against doing business with {Global.CompanyName} due to their unethical and subpar practices."
        };
        #endregion

        int badReviewAmount = 10-(int)Global.Reputation/10;
        Random soRandom = new Random();
        GD.Print(badReviewAmount);

        for (int i = 0; i < 9; i++) {
            if (i > badReviewAmount-1) {
                Text += "\"" + goodReviews[soRandom.Next(0,goodReviews.Length)] + "\"";
            } else {
                Text += "\"" + badReviews[soRandom.Next(0,badReviews.Length)] + "\"";
            }

            if (i < 8)
                Text += "\n";
        }
        base._Ready();
    }
}
