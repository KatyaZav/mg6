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
            aaa.Delete();
            Debug.Log("Good");
            SoundManagerBox.Instance.PlayClip(goodClip, 0.4f);
            pla.Destroy(goodEffect, true);
        }
        else
        {
            Debug.Log("Loose");
            SoundManagerBox.Instance.PlayClip(badClip, 0.4f);
            pla.Destroy(badEffect, false);
        }
    }

    private void Start()
    {
        aaa.AddCoun();
        //Debug.Log(player.BallCounts);
    }
}
