using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fin10floor : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject pyplayer;
    public GameObject japlayer;
    public GameObject emplayer;
    int state = 1;

    void Update()
    {
        if (state == 1)
        {
            pyplayer.SetActive(true);
        }
        else if (state == 2)
        {
            japlayer.SetActive(true);
        }
        else
        {
            emplayer.SetActive(true);
        }
    }
}
