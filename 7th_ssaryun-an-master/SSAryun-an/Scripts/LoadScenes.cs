using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    // functions only for scenechange(SC)
    public void SCMain()
    {
        SceneManager.LoadScene("main", LoadSceneMode.Single);
    }

    public void SCFloor1()
    {
        SceneManager.LoadScene("floor1",LoadSceneMode.Single);
    }

    public void SCFloor10()
    {
        SceneManager.LoadScene("floor10", LoadSceneMode.Single);
    }

    public void SCEleven()
    {
        SceneManager.LoadScene("eleven", LoadSceneMode.Single);
    }

}
