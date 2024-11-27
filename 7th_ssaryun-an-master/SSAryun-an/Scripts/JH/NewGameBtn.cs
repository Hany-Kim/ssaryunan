using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGameBtn : MonoBehaviour
{
    public void Change_new_game()
    {
        SceneManager.LoadScene("ProfileSettingScene1");
    }
}
