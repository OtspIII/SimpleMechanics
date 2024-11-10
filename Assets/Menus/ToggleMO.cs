using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleMO : MenuOption
{
    public bool TurnedOn = true;
    public string BaseText = "";

    public override void Execute()
    {
        TurnedOn = !TurnedOn;
        Text.text = BaseText + (TurnedOn ? "ON" : "OFF");
        if (Type == MenuOptions.Fullscreen)
        {
            //Pretend we had actual fullscreen code here
        }
    }
}
