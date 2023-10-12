using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public TypePlayer collecteblePlayer;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var pla = collision.gameObject.GetComponent<player>();

        if (pla == null) return;

        if (pla.type == collecteblePlayer)
        {
            Debug.Log("Good");
        }
        else
        {
            Debug.Log("Loose");
        }
    }
}
