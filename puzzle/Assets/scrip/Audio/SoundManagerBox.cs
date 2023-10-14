using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerBox : MonoBehaviour
{
    [SerializeField] float pitch = 0.04f;

    public static SoundManagerBox Instance;
    public AudioSource MusSorse;
    public AudioSource soundSorse;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
            Destroy(gameObject);

        UpdateSourseSettings(PlayerPrefs.GetInt(Setting.nMusic, 0),
            PlayerPrefs.GetInt(Setting.nSound, 0));
    }

    public void UpdateSourseSettings(int isMusicMute = 1, int isSoundMute = 1)
    {
        soundSorse.mute = 
            (isSoundMute == 1) ? true : false;

        MusSorse.mute =
            isMusicMute == 1 ? true : false;
    }


    public void PlayClip(AudioClip c, float vol = 0.3f)
    {
        Debug.Log("Played"+c);

        soundSorse.pitch =
            Random.Range(1 - pitch / 4, 1 + pitch);

        soundSorse.PlayOneShot(c, vol);
    }
}
