using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderMO : MenuOption
{
    public float CurrentValue = 100;
    public float MaxValue = 100;
    public float MinValue = 0;
    public float TimeToChange = 3;
    private float TimeMult;
    public string BaseText = "";

    void Start()
    {
        TimeMult = (MaxValue - MinValue) / TimeToChange;
    }
    
    public override void Run()
    {
        float change = 0;
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            change = -1;
            
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            change = 1;
        }
        if (change != 0)
        {
            CurrentValue += change * Time.deltaTime * TimeMult;
            CurrentValue = Mathf.Clamp(CurrentValue,MinValue,MaxValue);
            Text.text = BaseText + Mathf.Round(CurrentValue);
            if (Type == MenuOptions.AudioLevel)
            {
                //Pretend we had actual volume change code here
            }
        }
    }

}
