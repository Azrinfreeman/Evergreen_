using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class newTrigger : MonoBehaviour
{
    public List<Transform> itemtodo;

    public bool isAdding;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "action")
        {
            if (!isAdding)
            {
                for (int i = 0; i < itemtodo.Count; i++)
                {
                    itemtodo[i].gameObject.SetActive(true);
                }
                collision.GetComponent<DragController>().enabled = false;
            }
            else
            {
                if (transform.GetChild(3).GetComponent<Image>().fillAmount != 1)
                {
                    Debug.Log(transform.name);
                    transform.GetChild(3).GetComponent<Image>().fillAmount += 0.2f;
                }
                else
                {
                    if (GetComponent<Animator>())
                    {
                        GetComponent<Animator>().Play("dropletStart");
                    }
                    for (int i = 0; i < itemtodo.Count; i++)
                    {
                        itemtodo[i].gameObject.SetActive(true);
                    }
                    collision.transform.GetComponent<DragController>().enabled = false;
                }
            }
        }
    }
}
