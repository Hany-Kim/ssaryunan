using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class User_UI_scripts : MonoBehaviour
{
    
    public void BackPage()
    {
        SceneManager.LoadScene("SelectStageScene");
    }

}
