﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadScenes : MonoBehaviour
{
    public void loadGame()
    {
        SceneManager.LoadScene("Main");
    }
    public void loadSettings()
    {
        SceneManager.LoadScene("Settings");
    }
}
