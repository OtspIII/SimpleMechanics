using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneMO : MenuOption
{
    public string TargetScene;
    
    public override void Execute()
    {
        SceneManager.LoadScene(TargetScene);
    }
}
