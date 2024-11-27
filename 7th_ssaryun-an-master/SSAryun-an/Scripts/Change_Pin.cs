using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Pin : MonoBehaviour
{
    public GameObject[] pin_reds;
    public GameObject[] pin_greens;
    public void pin_change(int idx)
    {
        pin_reds[idx].SetActive(false);
        pin_greens[idx].SetActive(true);
    }
}