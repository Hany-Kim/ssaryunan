using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveAndGoSelectStage : MonoBehaviour
{
    public void GoSelectStage()
    {
        SceneManager.LoadScene("SelectStageScene");
    }
}
