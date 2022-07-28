using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Elem : MonoBehaviour
{
    public DataStructure ds;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnClick()
    {
        obj.GetComponent<TextMeshProUGUI>().text = "";
        obj.GetComponent<TextMeshProUGUI>().text += ds.content;
    }
}
