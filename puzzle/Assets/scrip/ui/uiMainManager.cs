using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uiMainManager : MonoBehaviour
{
    public static bool isPause = false;
    public void Load(string name)
    {
        SceneManager.LoadScene(name);
    }

    public void MuteSound()
    {
        Setting.UpdateSound();
    }

    public void MuteMusic()
    {
        Setting.updateMusic();
    }

    public void StartGame()
    {
        if (PlayerPrefs.GetInt(Setting.tutorial, 0) == 0)
        {
            Load("tutorial");
        }
        else
            Load("lvl" + PlayerPrefs.GetInt(Setting.level, 1).ToString());
    }


    private void Awake()
    {
        isPause = false;
    }

    public static void _Pause()
    {
        if (SceneManager.GetActiveScene().name == "tutorial")
            return;

        {
            isPause = !isPause;
            ManagerWindowloseandWin.Instance.ChangePause(isPause);
        }
    }

    public void Reload()
    {
        var scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}
