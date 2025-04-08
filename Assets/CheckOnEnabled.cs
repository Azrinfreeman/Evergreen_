using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckOnEnabled : MonoBehaviour
{
    public ConditionalCheck conditionCheck;
    // Start is called before the first frame update
    void Start()
    {
conditionCheck.CheckCondition();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnEnable()
    {
        
    }

}
