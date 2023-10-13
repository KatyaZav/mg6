using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SeveWinProgress : MonoBehaviour
{
    public Text text;

    private void OnEnable()
    {
        var currentScene = 
            SceneManager
            .GetActiveScene()
            .name;


        Debug.Log(
            currentScene[currentScene.Length - 1]);

        int number = (currentScene[currentScene.Length - 1]) - '0';

        if (number < 4)
            number++;

        PlayerPrefs.SetInt(Setting.level, number);
    }
}
