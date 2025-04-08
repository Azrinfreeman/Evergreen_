using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextExperimentController : MonoBehaviour
{
    [SerializeField]
    private Transform parent;

    [SerializeField]
    private Transform nextParent;

    // Start is called before the first frame update
    void Start()
    {
        parent = transform.parent;
        if (transform.parent.GetSiblingIndex() + 1 != transform.parent.transform.parent.childCount)
        {
            for (int i = 0; i < transform.parent.transform.parent.childCount; i++)
            {
                if (parent.transform.parent.GetChild(i).gameObject.activeSelf)
                {
                    nextParent = parent.transform.parent.GetChild(i + 1).transform;
                }
            }
        }
        if (transform.parent.GetSiblingIndex() + 1 == transform.parent.transform.parent.childCount)
        {
            GetComponent<Button>().transform.GetChild(0).GetComponent<TextMeshProUGUI>().text =
                "TAMAT";

            GetComponent<Button>().onClick.AddListener(() => tamat());
        }
        else
        {
            GetComponent<Button>().onClick.AddListener(() => NextExperiment());
        }
    }

    public void tamat()
    {
        SceneManager.LoadScene("Dashboard");
    }

    public void NextExperiment()
    {
        parent.gameObject.SetActive(false);
        nextParent.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update() { }
}
