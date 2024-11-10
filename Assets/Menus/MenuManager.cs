using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public MenuPage MainMenu;
    public MenuPage SettingsMenu;
    public List<MenuPage> AllPages;
    public static MenuManager MM;

    private void Awake()
    {
        MM = this;
        AllPages.Add(MainMenu);
        AllPages.Add(SettingsMenu);
    }

    public void OpenMenu(MenuPage menu)
    {
        foreach (MenuPage p in AllPages)
        {
            p.gameObject.SetActive(false);
        }
        menu.gameObject.SetActive(true);
    }
}
