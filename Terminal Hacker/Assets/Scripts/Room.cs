using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CyberpunkAdventure/Room")]
public class Room : ScriptableObject
{

    [TextArea]
    public string description;
    public string roomName;
}
