using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setActfalse_list : MonoBehaviour
{
    public Button thisbtn;
    public GameObject[] inactive_list;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = thisbtn.GetComponent<Button>();
        btn.onClick.AddListener(list_inactive);
    }

    // Update is called once per frame
    void list_inactive()
    {
        foreach(GameObject go in inactive_list)
        {
            go.SetActive(false);
        }
    }
}
