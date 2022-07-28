using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDataSet : MonoBehaviour
{
    public TextAsset json;

    public GameObject boutonElem;
    public GameObject buttonData;
    public GameObject ScrollView;
    public GameObject Content;
    public GameObject QuitButton;
    public GameObject Panel;

    private Data data;

    // Start is called before the first frame update
    void Start()
    {
        data = JsonUtility.FromJson<Data>("{\"dataStructures\":" + json.text + "}");
        transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = json.name;
    }


    public void OnClick()
    {
        if (!Panel.activeSelf)
        {
            Panel.SetActive(true);
        }


        foreach (Transform child in ScrollView.transform.Find("Viewport").Find("Content").transform)
        {
            Destroy(child.gameObject);
        }

        Content.GetComponent<TextMeshProUGUI>().text = "";
        for(int i =0; i<data.getDataSize(); i++)
        {
            GameObject elem = Instantiate(boutonElem);
            elem.transform.SetParent(ScrollView.transform.Find("Viewport").Find("Content"));
            elem.transform.GetChild(0).gameObject.GetComponent<TextMeshProUGUI>().text = data.getDataAt(i).title;
            elem.AddComponent<Elem>();
            elem.GetComponent<Elem>().ds = data.getDataAt(i);
            elem.GetComponent<Elem>().obj = Content;
            elem.GetComponent<Button>().onClick.AddListener(elem.GetComponent<Elem>().OnClick);

        }


    }
}
