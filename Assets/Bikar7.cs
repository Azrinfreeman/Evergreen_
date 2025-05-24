using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bikar7 : MonoBehaviour
{
    public Image fill;

    public Transform stirrer;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger");
        if (collision.gameObject.tag == "action")
        {
            fill.fillAmount += 0.2f;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "action")
        {
            collision
                .transform.parent.GetComponent<GetahCollection>()
                .nextButton.transform.gameObject.SetActive(true);
            collision.gameObject.GetComponent<DragController>().enabled = false;
            stirrer.transform.gameObject.SetActive(true);
        }
    }
}
