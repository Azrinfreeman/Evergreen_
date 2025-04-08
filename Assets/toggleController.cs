using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleController : MonoBehaviour
{
    private bool isToggle;

    public Transform object1;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void toggleOn()
    {
        if (!isToggle)
        {
            object1.gameObject.SetActive(true);

            isToggle = true;
        }
        else
        {

            object1.gameObject.SetActive(false);

            isToggle = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
