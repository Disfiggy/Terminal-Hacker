using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

    GameController controller;

	// Use this for initialization
	void Awake () {
        controller = GetComponent<GameController>();
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
        char[] delimiterCharacters = { ' ' };
        string[] seperatedInputWords = input.Split(delimiterCharacters);

        for (int i = 0; i < controller.inputActions.Length; i++)
        {
            InputAction inputAction = controller.inputActions[i];
            if (inputAction.keyWord == seperatedInputWords[0] && seperatedInputWords.Length > 1)
            {
                inputAction.RespondToInput(controller, seperatedInputWords);
            }
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
