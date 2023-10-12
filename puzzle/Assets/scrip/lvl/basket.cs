using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    public TypePlayer collecteblePlayer;

    public GameObject goodEffect;
    public AudioClip goodClip;
    public GameObject badEffect;
    public AudioClip badClip;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var pla = collision.gameObject.GetComponent<player>();

        if (pla == null) return;

        if (pla.type == collecteblePlayer)
        {
            Debug.Log("Good");
            Instantiate(goodEffect, collision.gameObject.transform.position, Quaternion.identity);
        }
        else
        {
            Debug.Log("Loose");
            Instantiate(badEffect, collision.gameObject.transform.position, Quaternion.identity);
        }
    }
}
