using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dead : MonoBehaviour
{
    public GameObject effect;
    public AudioClip clip;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(effect, collision.gameObject.transform.position, Quaternion.identity);
            SoundManagerBox.Instance.PlayClip(clip, 0.5f);

            Destroy(collision.gameObject);
            Debug.Log("loose");

            player.Loose();
        }
    }
}
