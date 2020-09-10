﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    private bool firstPush = false;

    public void PressStart()
    {
        Debug.Log("Press Start!");
        if (!firstPush)
        {
            Debug.Log("Go Next Scene!");
            SceneManager.LoadScene("GameScene");
            firstPush = true;
        }
    }
    public void BacktoTitle()
    {
        SceneManager.LoadScene("title");
    }
    public void Menu()
    {
        
    }
}
