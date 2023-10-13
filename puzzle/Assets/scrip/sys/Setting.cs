using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static string nMusic = "isMus";
    public static string nSound = "isSou";

    public static string level = "_curLvl";
    public static string tutorial = "wasTutorail";
    public static string Coin = "coins";

    public static string CurrentSkin = "curSkin";

    public static void UpdateSound()
    {
        var Sou = PlayerPrefs.GetInt(nSound);
        PlayerPrefs.SetInt(nSound, Sou == 1 ? 0 : 1);

        SoundManagerBox.Instance
            .UpdateSourseSettings(
            PlayerPrefs.GetInt(nMusic, 0), PlayerPrefs.GetInt(nSound, 0));
    }

    public static void updateMusic()
    {
        var Mus = PlayerPrefs.GetInt(nMusic);
        PlayerPrefs.SetInt(nMusic, Mus == 1 ? 0 : 1);

        SoundManagerBox
            .Instance
            .UpdateSourseSettings(PlayerPrefs.GetInt(nMusic), PlayerPrefs.GetInt(nSound));
    }
}
