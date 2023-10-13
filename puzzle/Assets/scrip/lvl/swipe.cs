using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe : MonoBehaviour
{
    public float speed = 1;

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

    bool isPause = false;

    private void OnMouseDrag()
    {
        if (isPause) return;

        var pos = Input.mousePosition;
        pos = Camera.main.ScreenToWorldPoint(pos);
        
        pos.y = transform.position.y;
        pos.z = 0;

        var vec = Vector3.Lerp(transform.position, pos, Time.fixedDeltaTime * speed);
        transform.position = vec;
    }
}
