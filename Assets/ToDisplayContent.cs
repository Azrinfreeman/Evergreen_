using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToDisplayContent : MonoBehaviour
{
    public List<Transform> items;

    public List<Transform> toDisplayItem;

    public bool allInactive;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i].gameObject.activeSelf)
            {
                allInactive = false;
                break;
            }
            else
            {
                allInactive = true;
            }
        }

        if (allInactive)
        {
            for (int i = 0; i < toDisplayItem.Count; i++)
            {
                toDisplayItem[i].gameObject.SetActive(true);
            }
            Debug.Log("All objects are inactive!");
        }
    }
}
