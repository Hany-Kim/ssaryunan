using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ssafyctrl : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject firsts;
    public GameObject seconds;
    public GameObject a;
    public GameObject f;
    public GameObject y;

    int flag = 0;



    void Update()
    {
        if (flag == 1)
        {
            firsts.SetActive(true);
        }
        if (flag == 2)
        {
            seconds.SetActive(true);
        }
        if (flag == 3)
        {
            a.SetActive(true);
        }
        if (flag == 4)
        {
            f.SetActive(true);
        }
        if (flag == 5)
        {
            y.SetActive(true);
        }

    }
}
