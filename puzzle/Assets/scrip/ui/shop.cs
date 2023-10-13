using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shop : MonoBehaviour
{
    private void Awake()
    {
        PlayerPrefs.GetInt("skin0", 1);
        PlayerPrefs.GetInt("skin1", 0);
        PlayerPrefs.GetInt("skin2", 0);
        PlayerPrefs.GetInt("skin3", 0);

        curSkin =
            PlayerPrefs.GetInt(Setting.CurrentSkin, 0);
    }

    public Text textOfCoins;
    public Sprite[] AllSkins;

    public Image skinOfImage;

    public GameObject buyButton, selectButton;

    public int curSkin;

    private void OnEnable()
    {
        UpdateSkinInfo();
        UpdateTextCoin();
    }

    void UpdateSkinInfo()
    {
        var isGet = PlayerPrefs.GetInt(
            "skin" + curSkin.ToString()) == 0 ? false : true;

        if (curSkin == 0)
            isGet = true;

        UpdateButtons(isGet);

        skinOfImage.sprite = AllSkins[curSkin];
    }


    void UpdateButtons(bool isActive)
    {
        var textOfBuyButton = buyButton.GetComponentInChildren<Text>();
        textOfBuyButton.text = "Buy" + string.Format($"( {curSkin * 5} )");

        selectButton.SetActive(isActive);
        buyButton.SetActive(!isActive);
    }

    public void MoveLeft()
    {
        curSkin--;

        if (curSkin < 0)
            curSkin = AllSkins.Length - 1;

        UpdateSkinInfo();
    }

    public void MoveRight()
    {
        curSkin++;

        if (curSkin > AllSkins.Length - 1)
            curSkin = 0;

        UpdateSkinInfo();
    }


    public void Select()
    {
        Debug.Log("Selected");

        PlayerPrefs.SetInt(Setting.CurrentSkin, curSkin);
    }

    public void Buy()
    {
        if (PlayerPrefs.GetInt(Setting.Coin) < curSkin * 5)
        {
            Debug.Log("Not enought money");
            return;
        }
        

        Debug.Log("Buyed");

        var newCoin = (PlayerPrefs.GetInt(Setting.Coin)) - (curSkin * 5);
        PlayerPrefs.SetInt((Setting.Coin), newCoin);

        PlayerPrefs.SetInt("skin" + curSkin.ToString(), 1);

        UpdateSkinInfo();
        UpdateTextCoin();        
    }
    void UpdateTextCoin()
    {
        textOfCoins.text = 
            PlayerPrefs.GetInt(Setting.Coin).ToString();
    }
}
