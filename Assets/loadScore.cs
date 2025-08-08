using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class loadScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMeshProUGUI>().text = ScoreController.instance.score + " / 50";
    }

    // Update is called once per frame
    void Update() { }
}
