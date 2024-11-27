using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizExit : MonoBehaviour
{
    public GameObject canvasUI;
    public GameObject astro;

    public void clickExit()
    {
        canvasUI.SetActive(false);
        astro.SetActive(true);
    }

}
