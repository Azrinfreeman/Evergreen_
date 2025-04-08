using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayItem : MonoBehaviour
{
    public List<Transform> items;

    public ConditionalCheck conditionCheck;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void SetupWire()
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].gameObject.SetActive(true);
        }
        conditionCheck.CheckCondition();
    }
    // Update is called once per frame
    void Update()
    {

    }
}
