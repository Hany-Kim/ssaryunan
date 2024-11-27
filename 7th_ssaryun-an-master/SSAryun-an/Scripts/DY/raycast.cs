using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
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
                //if(hit.transform.gameObject.name=="Astronaut_V1")
                if(hit.collider.name==gameObject.name)
                {
                    Debug.Log("gameObject Click");
                    gameObject.SetActive(false);
                    canvasUI.SetActive(true);

                }
            }
        }
    }
}
