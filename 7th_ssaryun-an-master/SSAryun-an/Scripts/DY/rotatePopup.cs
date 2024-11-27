using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePopup : MonoBehaviour
{
    public GameObject popupUI;
    public float degreePerSeconds = 900.0f;
    Quaternion rot;
    //int flag = 0;
    int flag2 = 0;
    int flag3 = 0;
    float tmp = 0;

    void Start()
    {
        rot = popupUI.transform.rotation;
    }
    public void ClickWrongBtn()
    {
        flag3 = 1;
    }

    void Update()
    {
        if (flag3 == 1)
        {
            float speed = degreePerSeconds * Time.deltaTime;
            if (flag2 == 0 || flag2 == 2)
            {
                tmp += speed;
                popupUI.transform.Rotate(Vector3.forward * speed);
                if(flag2 == 2 && tmp >= 0)
                {
                    flag2 = 0;
                    flag3 = 0;
                    tmp = 0;
                    popupUI.transform.rotation = rot;
                }
            }
            if (tmp > 15) flag2 = 1;
            else if (tmp < -15) flag2 = 2;
            if (flag2 == 1)
            {
                popupUI.transform.Rotate(Vector3.back * speed);
                tmp -= speed;
            }
        }
    }
}
