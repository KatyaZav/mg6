using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdGamSounder : MonoBehaviour
{
    public GameObject onGM;
    public GameObject offGM;


    public string Nmame;

    private void OnEnable()
    {
        ChangeBut();
    }

    public void ChangeBut()
    {
        if (PlayerPrefs.GetInt(Nmame) == 0) ActivateOnorOff(false);
        else ActivateOnorOff(true);
    }

    public void ActivateOnorOff(bool isOff)
    {
        onGM.SetActive(!isOff);
        offGM.SetActive(isOff);
    }
}
