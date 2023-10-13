using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteProgress : MonoBehaviour
{
    public void DeleteAll()
    {
        Debug.Log("deleted all");
        PlayerPrefs.DeleteAll();
    }

}
