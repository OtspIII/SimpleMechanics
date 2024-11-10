using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuOption : MonoBehaviour
{
    public MenuOptions Type;
    public TextMeshPro Text;

    void Awake()
    {
        if (Text == null) Text = GetComponent<TextMeshPro>();
    }

    public virtual void Run()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Execute();
        }
    }
    
    public virtual void Execute()
    {
        if (Type == MenuOptions.Quit)
        {
            Application.Quit();
        }
        else if (Type == MenuOptions.SettingsMenu)
        {
            MenuManager.MM.OpenMenu(MenuManager.MM.SettingsMenu);
        }
        else if (Type == MenuOptions.Fullscreen)
        {
            Debug.Log("TO BE ADDED");
        }
        else if (Type == MenuOptions.AudioLevel)
        {
            Debug.Log("TO BE ADDED");
        }
        else if (Type == MenuOptions.MainMenu)
        {
            MenuManager.MM.OpenMenu(MenuManager.MM.MainMenu);
        }
    }

    public void Highlight()
    {
        GetComponent<TextMeshPro>().color = Color.yellow;
    }

    public void Reset()
    {
        GetComponent<TextMeshPro>().color = Color.white;
    }
}

public enum MenuOptions
{
    None=0,
    StartGame=1,
    SettingsMenu=2,
    Quit=3,
    Fullscreen=4,
    AudioLevel=5,
    MainMenu=6
}
