using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

public class NameSettingDoneBtn : MonoBehaviour
{
    public TextMeshProUGUI newPlayerName;


    public void NameSetCheck()
    {
        //DataManager.instance.nowPlayer.name = newPlayerName.text;
        SceneManager.LoadScene("ProfileSettingScene2");
    }
}
