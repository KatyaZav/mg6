using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSounds : MonoBehaviour
{
    public AudioClip buttonSound;
    private void OnEnable()
    {
        ActivatesAllButton();
    }

    public void SoundOnButtonClick()
    {
        SoundManagerBox.Instance.PlayClip(buttonSound, 0.8f);
    }

    void ActivatesAllButton()
    {
        var buttons = FindObjectsOfType<Button>();

        foreach (var button in buttons)
        {
            button.onClick.AddListener(SoundOnButtonClick);
        }
    }
}
