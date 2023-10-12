using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public TypePlayer type;
}


[System.Serializable]
public enum TypePlayer
{
    red,
    blue,
}