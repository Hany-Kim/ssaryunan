using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class setActtrue_list : MonoBehaviour
{
    public Button thisbtn;
    public GameObject[] active_list;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = thisbtn.GetComponent<Button>();
        btn.onClick.AddListener(list_active);
    }

    // Update is called once per frame
    void list_active()
    {
        foreach (GameObject go in active_list)
        {
            go.SetActive(true);
        }
    }
}
