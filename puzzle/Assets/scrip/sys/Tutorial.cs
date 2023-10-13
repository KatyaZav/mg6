using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{

    [SerializeField] private Text textForTuroe;
    [SerializeField] private Button nextTextButton;

    [SerializeField] private string[] AllNeedToSayText;

    private void CloseT()
    {
        SceneManager.LoadScene("lvl1");
    }

    private void Start()
    {
        DialogLogic();
    }

    int index;
    private void DialogLogic()
    {
        textForTuroe.text = AllNeedToSayText[index];



        nextTextButton            
            .onClick
            .AddListener
            (() =>
        {
            if (index >= AllNeedToSayText.Length)
                return;

            index++;

            if (index >= AllNeedToSayText.Length)
            {
                PlayerPrefs.SetInt(Setting.tutorial, 1);
                Invoke("CloseT", 0.1f);
                return;
            }

            textForTuroe.text = AllNeedToSayText[index];
        });
    }


}
