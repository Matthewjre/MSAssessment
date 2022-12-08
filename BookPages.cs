using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BookPages : MonoBehaviour
{
    
    
    private static String Intro1 = "Welcome to the chemistry lab! This book will serve as your guide to the experiments.";
    private static String Intro2 = "You can grab this book with the Grasp button and flip the pages using the Trigger button on your controller.";
    private static String Intro3 = "Most of the things you can interact with also use this scheme. Some items are highlighted a red color...";
    private static String Intro4 = "These red objects are hand sensors that we use to prevent you from getting chemicals everywhere. Simply wave your hand...";
    private static String Intro5 = "across the sensor and the nearby object will turn on for a set amount of time. Go ahead and try it.";
    private static String Safety1 = "The first step before we get into the experiments is to review the safety equipment we have here.";
    private static String Safety2 = "Go ahead and walk around the lab and identify and test the following items on the next page.";
    private static String Safety3 = "Identify:\nFire extinguisher\nEye wash station\nSafety Shower\nHand washing sink";
    private static String Safety4 = "Now that all of the safety features have been identified, let's begin with the first experiment!";
    
    private static String Safety5 = "Remember! In a chemistry lab, you should always make slow and controlled movements. You don't want your compounds to ignite in your hands because you were moving too quickly!";

    private static String KClO3_1 = "the first experiment you'll be doing is Potassium Chlorate (KClO3) and regular table sugar mixed with sulfuric acid.";
    private static String KClO3_2 = "Potassium chlorate is a white powder that acts as a good oxidizing agent. Furthermore, it decomposes under heat.";

    private static String KClO3_3 = "We can prodivide this heat using two things: sugar (which if you've ever eaten chocolate you know has plenty of energy) and a catalyst.";
    private static String KClO3_4 = "When sulfuric acid is mixed with sugar, the acid removes all the water from the suger in a highly exothermic reaction which produces the heat we need.";
    private static String KClO3_5 = "in this reaction specifically, we can see a bright purple flame. This is due to the electrons in the potassium jouming to higher energy levels and produce this special purple light";

    private static String acetylene1 = "The next experiment we'll be doing is a demonstration of how reactive even the simplest alkyne, Acetylene (C2H2), can be.";
    private static String acetylene2 = "In our red balloon, we have combined acetylene and oxygen, which produces CO2, water, and a lot of heat in a very small amount of time.";
    private static String acetylene3 = "To get our acetylene and oxygen to react, we need provide a little bit of our own heat to begin the reaction.";
    private static String acetylene4 = "The carbon atoms in acetylene are tripple bonded together, leaving a lot of excess energy that wants a place to go. There is so much excess energy, it escapes very quickly when we provide heat.";
    private static String sodium1 = "The last reaction we have is a classic: sodium and water.";
    private static String sodium2 = "Sodium, like the rest of the alkali metals are HIGHLY reactive due to its single outer electron which makes the metal desparate to form a bond.";
    private static String sodium3 = "This transfer of electrons from the sodium to the water releases a massive amount of energy, resulting in the explosion you'll see in the demo.";

    public List<String> pages = new List<String>{
        Intro1,
        Intro2,
        Intro3,
        Intro4,
        Intro5,
        Safety1,
        Safety2,
        Safety3,
        Safety4,
        Safety5,
        KClO3_1,
        KClO3_2,
        KClO3_3,
        KClO3_4,
        KClO3_5,
        acetylene1,
        acetylene2,
        acetylene3,
        acetylene4,
        sodium1,
        sodium2,
        sodium3,


    };

    //IMPORTANT - for the book to actually update, you need to go into the "pages" object in the Grab Book in the hierarchy, look for the book pages component and RESET it.
    // you should then see the number of pages update and your new page will be added there. this INCLUDES editing already existing pages



    
    

}
