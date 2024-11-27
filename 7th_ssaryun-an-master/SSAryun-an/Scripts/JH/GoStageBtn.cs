using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoStageBtn : MonoBehaviour
{
    public void GoFloor1()
    {
        SceneManager.LoadScene("floor1");
    }
    public void GoFloor10()
    {
        SceneManager.LoadScene("floor10");
        //SceneManager.LoadScene("floor10 1");
    }
    public void GoFloor11()
    {
        SceneManager.LoadScene("eleven");
    }
    public void GoFloor18()
    {
        SceneManager.LoadScene("");
    }
}
