using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameMainMenu();
    }
	
    void GameMainMenu ()
    {
        Terminal.WriteLine("                     == ADVENTURES ON XANION ==");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("=====================================================================");
        Terminal.WriteLine("=                       CHOOSE YOUR ADVENTURE                       =");
        Terminal.WriteLine("=====================================================================");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("                      [ - Difficulty Easy -   ]");
        Terminal.WriteLine("                      [ - Difficulty Medium - ]");
        Terminal.WriteLine("                      [ - Difficulty Hard -   ]");
    }

    void MainStoryIntroduction ()
    {
        Terminal.WriteLine("Hello fellow traveler.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("You have entered the world of Xanion 281-Z through the gate system.");
        Terminal.WriteLine("The world of Xanion is a digital world that is due to its code basis visualized as highly deserted world.");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("There are sand dunes as far as they eye can see, but in the distance you are able to distinguish a rock like construction");
        Terminal.WriteLine("The sun is going to be setting in a few hours and after that the environment will most likely become uninhabitable for any human");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("Would you like to continue forward? (Y/N)");
    }

    void OnUserInput(string input)
    {
        if (input == "Easy")
        {
            Terminal.ClearScreen();
            MainStoryIntroduction();
        }
        else if (input == "Medium")
        {
            Terminal.ClearScreen();
            MainStoryIntroduction();
        }
        else if (input == "Hard")
        {
            Terminal.ClearScreen();
            MainStoryIntroduction();
        }
        else
        {       
            Terminal.WriteLine("Please Choose a Valid Adventure Fellow Traveler");
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
