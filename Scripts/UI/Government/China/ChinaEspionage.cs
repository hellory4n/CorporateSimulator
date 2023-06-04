using Godot;
using System;

public class ChinaEspionage : Label {
    public override void _Ready() {
        string[] facts = new string[] {
            "China is the world's most populous country, with over 1.4 billion people.",
            "It is located in East Asia and is the fourth largest country by land area.",
            "Chinese is the official language of China.",
            "The Great Wall of China is one of the most iconic landmarks in the world.",
            "China has a written history of over 5,000 years.",
            "The capital city of China is Beijing.",
            "China is a socialist country with a one-party political system.",
            "The Chinese currency is called the Renminbi (RMB) or Chinese yuan (CNY).",
            "China is the world's second-largest economy.",
            "The Terracotta Army, discovered in Xi'an, is a famous archaeological site in China.",
            "Chinese cuisine is known for its diverse flavors and regional specialties.",
            "China is known for its rich cultural heritage, including traditional arts such as calligraphy and painting.",
            "The Forbidden City in Beijing was the imperial palace of the Ming and Qing dynasties.",
            "China has the largest standing army in the world.",
            "The country has a high-speed rail network that is among the longest in the world.",
            "Chinese New Year, also known as Spring Festival, is the most important traditional holiday in China.",
            "Pandas are native to China and are considered a national treasure.",
            "China is a major producer and consumer of renewable energy, particularly solar and wind power.",
            "The Three Gorges Dam on the Yangtze River is the world's largest hydropower project.",
            "Chinese philosophy has greatly influenced the culture of East Asia, with Confucianism being one of the most important schools of thought.",
            "Chinese martial arts, such as Kung Fu, have gained worldwide popularity.",
            "China is home to the world's highest peak, Mount Everest, on its border with Nepal.",
            "The Silk Road was an ancient network of trade routes that connected China with the Middle East and Europe.",
            "China is a permanent member of the United Nations Security Council.",
            "The country has a vast and diverse landscape, including deserts, mountains, plains, and coastlines.",
            "Chinese tea culture has a long history and is deeply rooted in Chinese society.",
            "The giant salamander, found in China, is the largest amphibian in the world.",
            "China is known for its intricate and colorful traditional festivals, such as the Lantern Festival and Dragon Boat Festival.",
            "The Chinese space program has made significant advancements, including manned space missions and lunar exploration.",
            "Chinese technology companies, such as Huwhatisgoingon and Showme, are global leaders in the telecommunications and electronics industries.",
            "China is the world's largest producer and consumer of automobiles.",
            "The country has a rich tradition of traditional medicine, including acupuncture and herbal remedies.",
            "The Yellow River, known as the 'Mother River of China,' is the second-longest river in the country.",
            "Chinese literature has a long history and includes famous works such as 'Journey to the West' and 'Dream of the Red Chamber.'",
            "China has a diverse range of ethnic groups, with the Han Chinese being the majority.",
            "The Shanghai Stock Exchange is one of the largest stock exchanges in the world.",
            "Chinese calligraphy is considered a form of art and is highly regarded.",
            "The panda is a symbol of peace and friendship in Chinese culture.",
            "China has the world's largest high-speed railway network.",
            "The country is a major producer and exporter of goods, including electronics, textiles, and machinery.",
            "Chinese inventions include paper, gunpowder, compass, and printing techniques.",
            "The Beijing Olympics were held in China in 2008.",
            "China has a five-year economic plan that guides its development and growth.",
            "Chinese characters are logographic, meaning each character represents a word or idea.",
            "China has a long tradition of ceramics and is famous for its porcelain.",
            "The country has a complex system of traditional etiquette and customs.",
            "Chinese traditional music is characterized by its unique instruments, such as the guzheng and erhu.",
            "China is a leading producer of steel and coal.",
            "The country has a diverse range of traditional clothing styles, such as the cheongsam and qipao.",
        };
        Random randomlolhaha = new Random();
        Text = "After sending spies to China and harming our diplomatic friendship, we have gotten the following information: \n\n" + facts[randomlolhaha.Next(0, facts.Length)];
        Global.China.Friendship -= 10;
        base._Ready();
    }
}
