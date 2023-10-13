using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public static int BallCounts = 0;

    public TypePlayer type;

    public void Destroy(GameObject effect, bool isRightBusket)
    {
        Instantiate(effect, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);

        if (!isRightBusket)
        {
            Loose();
            return;
        }

        BallCounts--;

        if (BallCounts <= 0)
            Win();
    }

    public static Action Loosed;
    public static void Loose()
    {
        Debug.Log("Loose");
        Loosed?.Invoke();
    }
    
    public static Action Wined;
    public static void Win()
    {
        Debug.Log("Win");
        Wined?.Invoke();
    }
}


[System.Serializable]
public enum TypePlayer
{
    pink,
    green,
}