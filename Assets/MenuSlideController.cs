using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSlideController : MonoBehaviour
{
    public Transform currentTransform;
    public int index;

    public List<Transform> Contents;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Contents.Add(transform.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void UpArrow()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                Debug.Log(transform.childCount);
                currentTransform = transform.GetChild(i).transform;
                currentTransform.gameObject.SetActive(false);
                index = currentTransform.transform.GetSiblingIndex();
                index--;

                if (index < 0)
                {
                    index = 0;
                }
                Contents[index].transform.gameObject.SetActive(true);
                return;
            }
        }

    }
    public void DownArrow()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            if (transform.GetChild(i).gameObject.activeSelf)
            {
                Debug.Log(transform.childCount);
                currentTransform = transform.GetChild(i).transform;
                currentTransform.gameObject.SetActive(false);
                index = currentTransform.transform.GetSiblingIndex();
                index++;

                if (index >= transform.childCount)
                {

                    index = transform.childCount - 1;
                }
                Contents[index].transform.gameObject.SetActive(true);
                return;
            }
        }

    }
}
