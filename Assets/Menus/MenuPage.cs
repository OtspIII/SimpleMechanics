using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MenuPage : MonoBehaviour
{
    public GameObject Selector;
    public List<MenuOption> Options;
    public int Selected;

    private void Start()
    {
        CurrentOption().Highlight();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            CurrentOption().Reset();
            Selected++;
            if (Selected >= Options.Count)
            {
                Selected = 0;
            }
            SyncSelector();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CurrentOption().Reset();
            Selected--;
            if (Selected < 0)
            {
                Selected = Options.Count - 1;
            }
            SyncSelector();
        }
        CurrentOption().Run();

    }

    public MenuOption CurrentOption()
    {
        return Options[Selected];
    }

    void SyncSelector()
    {
        MenuOption current = CurrentOption();
        Selector.transform.position = new Vector3(0, current.transform.position.y, 0);
        current.Highlight();
        
    }

}
