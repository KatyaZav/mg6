using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aaa : MonoBehaviour
{
    public static int Counts;
    private void Awake()
    {
        Counts = 0;
    }

    public static void AddCoun()
    {
        Counts++;

        //Debug.Log(Counts);
    } 

    public static void Delete()
    {
        Debug.Log(Counts);
        Counts--;
        if (Counts <= 0)
            player.Win();
    }
}
