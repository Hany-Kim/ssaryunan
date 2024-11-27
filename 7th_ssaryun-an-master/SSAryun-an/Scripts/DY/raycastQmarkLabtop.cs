using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastQmarkLabtop : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject canvasUI;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //if(hit.transform.gameObject.name=="Object_Qmark")
                if(hit.collider.name=="Object_Qmark_Labtop")
                {
                    Debug.Log("Object_qmark Click");
                    gameObject.SetActive(false);
                    canvasUI.SetActive(true);

                }
            }
        }
    }
}
