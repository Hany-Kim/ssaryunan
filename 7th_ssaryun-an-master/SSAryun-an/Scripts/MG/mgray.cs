using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mgray : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject character1;

    public float degreePerSeconds = 3.0f;

    int flag = 0;
    int flag2 = 0;
    float tmp = 0;
    void Start()
    {
        
    }

    void Update()
    {
        //float speed = degreePerSeconds * Time.deltaTime;
        //transform.Rotate(Vector3.up * speed);
        //Debug.Log("hello world");

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if(hit.transform.gameObject.name=="Astronaut_V1" || hit.transform.gameObject.name == "Astronaut_V3")
                {
                    Debug.Log("Astronaut_V1");
                    gameObject.SetActive(true);
                    //character1.SetActive(false);
                    if (flag == 0) flag = 1;
                    else flag = 0;
                }
            }
            //float speed = degreePerSeconds * Time.deltaTime;
            //transform.Rotate(Vector3.up * speed);
        }
        if (flag == 1)
        {
            float speed = degreePerSeconds * Time.deltaTime;
            if (flag2 == 0)
            {
                tmp += speed;
                transform.Rotate(Vector3.up * speed);
            }
            if (tmp > 500) flag2 = 1;
            else if (tmp < 0) flag2 = 0;
            if (flag2 == 1)
            {
                transform.Rotate(Vector3.down * speed);
                tmp -= speed;
            }
            Debug.Log("speed" + speed);
        }
    }
}
