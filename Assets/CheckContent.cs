using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckContent : MonoBehaviour
{
    public List<Transform> item;

    public List<Transform> toAppear;

    public int l;

    public bool toDisappear;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < item.Count; i++)
        {
            l = 0;
            if (!toDisappear)
            {
                if (!item[i].gameObject.activeSelf)
                {
                    l++;
                    if (i == l)
                    {
                        toAppear[0].gameObject.SetActive(true);
                        if (toAppear[1] != null)
                        {
                            toAppear[1].gameObject.SetActive(true);
                        }
                        if (toAppear[2] != null)
                        {
                            toAppear[2].gameObject.SetActive(true);
                        }
                    }
                }
            }
            else
            {
                if (item[i].gameObject.activeSelf)
                {
                    l++;
                    if (i == l)
                    {
                        toAppear[0].gameObject.SetActive(true);
                        if (toAppear[1] != null)
                        {
                            toAppear[1].gameObject.SetActive(true);
                        }
                        if (toAppear[2] != null)
                        {
                            toAppear[2].gameObject.SetActive(true);
                        }
                    }
                }
            }
        }
    }
}
