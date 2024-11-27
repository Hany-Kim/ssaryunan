using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickBack : MonoBehaviour
{
    public GameObject canvasUi;
    public GameObject cube;
    public GameObject gameObject;
    public GameObject question;
    public GameObject answerYes;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;
    public GameObject backbtn;

    public void goBack()
    {
        gameObject.SetActive(true);
        answerYes.SetActive(true);
        backbtn.SetActive(true);

        question.SetActive(false);
        answer1.SetActive(false);
        answer2.SetActive(false);
        answer3.SetActive(false);
        answer4.SetActive(false);
        canvasUi.SetActive(false);
        cube.SetActive(true);
    }
}
