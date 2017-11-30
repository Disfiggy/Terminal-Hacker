using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputAction
{
    public string keyWord;

    public abstract void RespondToInput(GameController controller, string[] seperatedInputWords);
	
}
