using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour {

	// Use this for initialization
	void Start () {
        MainStoryIntroduction();
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

	// Update is called once per frame
	void Update () {
		
	}
}
