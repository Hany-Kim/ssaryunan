using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using TMPro;

using System;

public class ProfileEditCompleteBtn : MonoBehaviour
{
    public TMP_InputField newPlayerName;

    public void Edit()
    {
        if (newPlayerName.text != System.String.Empty) ;
           // DataManager.instance.nowPlayer.name = newPlayerName.text;
    }
}
