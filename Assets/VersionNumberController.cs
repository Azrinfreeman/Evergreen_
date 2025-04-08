using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class VersionNumberController : MonoBehaviour
{
    public static VersionNumberController instance;
    public TextMeshProUGUI text;

    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

        text = GetComponent<TextMeshProUGUI>();

        text.text = Application.version;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
