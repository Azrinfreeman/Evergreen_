using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GetahCollection : MonoBehaviour
{
    public static GetahCollection instance;

    public Transform nextButton;

    void Awake()
    {
        instance = this;
    }

    public List<Transform> items;

    // Start is called before the first frame update
    void Start()
    {
        items[0].transform.gameObject.SetActive(true);
    }

    public void clearAndNextItem()
    {
        nextButton.gameObject.SetActive(false);
        items[0].transform.gameObject.SetActive(false);
        items.RemoveAt(0);
        if (items.Count > 0)
        {
            items[0].transform.gameObject.SetActive(true);
        }
        if (items.Count == 1)
        {
            nextButton.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "TUNGGU 2 JAM";
        }
    }

    // Update is called once per frame
    void Update() { }
}
