using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChange : MonoBehaviour
{
    SpriteRenderer spr;
    public Sprite[] skins;

    private void Awake()
    {
        spr = GetComponent<SpriteRenderer>();
        spr.sprite = skins[PlayerPrefs.GetInt(Setting.CurrentSkin)];
    }
}
