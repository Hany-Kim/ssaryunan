using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yfindctrl : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject nextstep;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //if(hit.transform.gameObject.name=="Astronaut_V1")
                if (hit.collider.name == gameObject.name)
                {
                    Debug.Log("gameObject Click");
                    gameObject.SetActive(false);
                    nextstep.SetActive(true);

                }
            }
        }
    }
}
