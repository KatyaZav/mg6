using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ball;
    bool isGameStart = false;

    bool isPause;

    private void Awake()
    {
        ManagerWindowloseandWin.ChangePausedSettings += Change;
    }

    private void OnDestroy()
    {
        ManagerWindowloseandWin.ChangePausedSettings -= Change;
        
    }

    void Change(bool u)
    {
        isPause = u;
    }

    private void OnMouseDown()
    {
        if (isPause)
            return;

        if (!isGameStart)
        {
            Instantiate(ball, transform.position, Quaternion.identity);
            isGameStart = true;
        }
    }
}
