using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycastEmark : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject pymodel;
    public GameObject jamodel;
    public GameObject emmodel;
    public AudioSource pyaudio;
    public AudioSource jaaudio;
    public AudioSource emaudio;

    void Update()
    {
        int state = 1;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                //if(hit.transform.gameObject.name=="Object_Emark")
                if (hit.collider.name == gameObject.name)
                {

                    gameObject.SetActive(false);
                    if (state == 1)
                    {
                        pyaudio.Play();
                        Invoke("audioFinished", pyaudio.clip.length);
                        pymodel.SetActive(true);
                    }
                    else if (state == 2)
                    {
                        jaaudio.Play();
                        Invoke("audioFinished", jaaudio.clip.length);
                        jamodel.SetActive(true);
                    }
                    else
                    {
                        emaudio.Play();
                        Invoke("audioFinished", emaudio.clip.length);
                        emmodel.SetActive(true);
                    }

                }
            }
        }

    }

    void audioFinished()
    {
        pymodel.SetActive(false);
        jamodel.SetActive(false);
        emmodel.SetActive(false);
    }
}
