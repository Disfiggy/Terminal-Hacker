using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text displayText;

    [HideInInspector] public RoomNavigation roomNavigation;

    List<string> actionLog = new List<string>();

	// Use this for initialization
	void Awake ()
    {
        roomNavigation = GetComponent<RoomNavigation>();
	}

    void Start()
    {
        DisplayRoomText();
        DisplayLoggedText();
    }

    public void DisplayLoggedText ()
    {
        string LogAsText = string.Join("\n", actionLog.ToArray());

        displayText.text = LogAsText;
    }

    public void DisplayRoomText()
    {
        string CombinedText = roomNavigation.currentRoom.description + "\n";

        LogStringWithReturn(CombinedText);

        Terminal.WriteLine(CombinedText);
    }
	
    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
