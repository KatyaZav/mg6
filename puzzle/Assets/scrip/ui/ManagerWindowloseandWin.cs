using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerWindowloseandWin : MonoBehaviour
{
    public GameObject winGM, loseGM;
    public bool isCurTut = false;

    public static ManagerWindowloseandWin Instance;

    public static Action<bool> ChangePausedSettings;

    private void Awake()
    {
        Instance = this;

        player.Loosed += Lose;
        player.Wined += Wined;

        ChangePause(false);
    }

    private void OnDestroy()
    {
        player.Loosed -= Lose;
        player.Wined -= Wined;
    }

    public void ChangePause(bool isPause)
    {
        //Debug.Log("Pause");
        ChangePausedSettings?.Invoke(isPause);
    }

    void Lose()
    {
        if (isCurTut) return;

        
            loseGM.SetActive(true);
            uiMainManager._Pause();
        
    }

    void Wined()
    {
        if (isCurTut) return;

        
            winGM.SetActive(true);
            uiMainManager._Pause();
        
    }
}
