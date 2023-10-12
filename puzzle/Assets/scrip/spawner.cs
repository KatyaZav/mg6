using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject ball;
    bool isGameStart = false;

    private void OnMouseDown()
    {
        if (!isGameStart)
        {
            Instantiate(ball, transform.position, Quaternion.identity);
            isGameStart = true;
        }
    }
}
