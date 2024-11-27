using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PictureSettingDoneBtn : MonoBehaviour
{
    public void PictureSetCheck()
    {
        SceneManager.LoadScene("InfoInputCompleteScene");
    }
}
