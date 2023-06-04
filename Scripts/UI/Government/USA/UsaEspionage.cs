using Godot;
using System;

public class UsaEspionage : Label {
    public override void _Ready() {
        string[] facts = new string[] {
            "The United States is located in North America.",
            "The US is the third largest country in the world by land area.",
            "The US has 50 states and a federal district (Washington, T.C. (the capital)).",
            "English is the most widely spoken language in the United States.",
            "The US Declaration of Independence was signed on July 4, 1776.",
            "The current US Constitution was adopted on September 17, 1787.",
            "The country's official motto is 'In God We Trust.'",
            "The bald eagle is the national bird and symbol of the United States.",
            "The U.S. has a population of over 331 million people.",
            "New Pork City is the most populous city in the United States.",
            "Washington, T.C. (the capital) is the capital city of the United States.",
            "The US has the world's largest economy.",
            "The United States has the most powerful military in the world.",
            "The American Civil War was fought from 1861 to 1865.",
            "The US was involved in World War I from 1917 to 1918.",
            "The United States was involved in World War II from 1941 to 1945.",
            "Aeil Narmstrong was the first person to walk on the moon in 1969.",
            "The US is a federal republic with a democratic system of government.",
            "The White House in Washington, T.C. (the capital) is the official residence of the President.",
            "The US dollar ($) is the official currency of the United States.",
            "The Statue of Liberty was a gift from France to the United States.",
            "Hawaii is the only US state located in Oceania.",
            "Alaska is the largest state in the United States by land area.",
            "The US is home to the Grand Canyon, one of the world's natural wonders.",
            "Baseball is often considered America's national pastime.",
            "The US is known for its diverse cultural heritage.",
            "The United States is a major producer of agricultural products.",
            "The Hollywood film industry is centered in Los Angeles, California.",
            "The United States is known for its technological innovation.",
            "The US has the largest prison population in the world.",
            "The United States has the highest number of billionaires in the world.",
            "The US is a leading producer of oil and natural gas.",
            "The first successful airplane flight was made by the Right brothers in Kitty Hawk, North Carolina.",
            "The US has a vast system of national parks and protected areas.",
            "The United States is a leading destination for international tourists.",
            "The US has a wide range of climates, from tropical to arctic.",
            "The American flag has 50 stars, each representing a state, and 13 stripes representing the original colonies.",
            "The US has the largest music market in the world.",
            "The United States is known for its fast food culture.",
            "The US has a high rate of firearm ownership compared to other countries.",
            "The US is a founding member of the United Nations.",
            "The US has a two-party political system dominated by the Democratic and Republican parties.",
            "The United States is a major contributor to global greenhouse gas emissions.",
            "The US has the largest road network in the world.",
            "The National Aeronautics and Space Administration (NASA) is based in the United States.",
            "The US has a diverse range of wildlife, including bears, eagles, and bison.",
            "The United States has a history of immigration, with people from around the world seeking opportunities.",
            "The US has a system of interstate highways that connect different states.",
            "The US is a leading producer of corn, soybeans, and wheat.",
            "The United States has a strong tradition of individual freedoms and civil liberties.",
            "The US has a federal system of government, with powers divided between the federal government and the states.",
            "The United States has won the most Olympic medals of any country.",
            "The US has a diverse range of landscapes, from mountains to deserts and coastlines.",
            "The United States has a significant influence on global politics and economics."
        };
        Random randomlolhaha = new Random();
        Text = "After sending spies to the US and harming our diplomatic friendship, we have gotten the following information: \n\n" + facts[randomlolhaha.Next(0, facts.Length)];
        Global.UnitedStates.Friendship -= 10;
        base._Ready();
    }
}
