using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizQuestion : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject question;
    public GameObject answerYes;
    public GameObject answer1;
    public GameObject answer2;
    public GameObject answer3;
    public GameObject answer4;

    public void ClickYes()
    {
        gameObject.SetActive(false);
        answerYes.SetActive(false);
        question.SetActive(true);
        answer1.SetActive(true);
        answer2.SetActive(true);
        answer3.SetActive(true);
        answer4.SetActive(true);
    }

    //void Update()
    //{
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        Debug.Log("AAA"+hit.transform.gameObject.name);
        //        if (hit.transform.gameObject.name == "Ready")
        //        {
        //            Debug.Log("Click Ready");
        //            gameObject.SetActive(false);
        //            question.SetActive(true);
        //            answer1.SetActive(true);
        //            answer2.SetActive(true);
        //            answer3.SetActive(true);
        //            answer4.SetActive(true);
        //        }
        //    }
        //}
    //}
}
