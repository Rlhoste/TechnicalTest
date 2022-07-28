using UnityEngine;
using TMPro;

public class ButtonDelete : MonoBehaviour
{

    public GameObject Content;
    public GameObject Panel;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void onClick()
    {
        Content.GetComponent<TextMeshProUGUI>().text = "";
        Panel.SetActive(false);
    }
}
