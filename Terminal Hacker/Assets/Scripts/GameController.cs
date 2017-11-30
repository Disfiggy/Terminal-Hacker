using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public Text displayText;
    public InputAction[] inputActions;

    [HideInInspector] public RoomNavigation roomNavigation;
    [HideInInspector] public List<string> interactionDescriptionsInRoom = new List<string>();

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
        ClearCollectionsForNewRoom();

        UnpackRoom ();

        string JoinedInteractionDescriptions = string.Join("\n", interactionDescriptionsInRoom.ToArray());

        string CombinedText = roomNavigation.currentRoom.description + "\n" + JoinedInteractionDescriptions;

        LogStringWithReturn(CombinedText);

        Terminal.WriteLine(CombinedText);
    }

    void UnpackRoom()
    {
        roomNavigation.UnpackExitsInRoom ();
    }
	
    void ClearCollectionsForNewRoom()
    {
        interactionDescriptionsInRoom.Clear();
        roomNavigation.ClearExits();
    }

    public void LogStringWithReturn(string stringToAdd)
    {
        actionLog.Add(stringToAdd + "\n");
    }

	// Update is called once per frame
	void Update () {
		
	}
}
