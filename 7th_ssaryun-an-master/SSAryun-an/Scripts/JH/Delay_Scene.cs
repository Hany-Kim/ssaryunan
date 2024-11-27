using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay_Scene : MonoBehaviour
{
    bool loadingStarted = false;
    float secondsLeft = 0;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DelayLoadLevel(2));
    }

    IEnumerator DelayLoadLevel(float seconds)
    {
        secondsLeft = seconds;
        loadingStarted = true;
        do
        {
            yield return new WaitForSeconds(1);
        } while (--secondsLeft > 0);

        Application.LoadLevel("GameWaitingScene");

        void OnGUI()
        {
            if (loadingStarted)
                GUI.Label(new Rect(0, 0, 100, 20), secondsLeft.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
