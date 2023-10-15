using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        ManagerWindowloseandWin.ChangePausedSettings += SetPause;
    }

    private void OnDestroy()
    {
        ManagerWindowloseandWin.ChangePausedSettings -= SetPause;
        
    }

    void SetPause(bool isPause)
    {
        if (isPause)
            rb.bodyType = RigidbodyType2D.Static;
        else
            rb.bodyType = RigidbodyType2D.Dynamic;

            
    }

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

    public GameObject effect;
    public AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "box")
        {
            var e = UnityEngine.Random.Range(1, 5);


            if (e < 3)
            {
                //Debug.Log(e);
                Instantiate(effect, transform.position, Quaternion.identity);
                SoundManagerBox.Instance.PlayClip(clip);
            }
        }
    }
}


[System.Serializable]
public enum TypePlayer
{
    pink,
    green,
}