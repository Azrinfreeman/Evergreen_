using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuhuBilikControl : MonoBehaviour
{
    public ConditionalCheck conditionalCheck;
    public triggerHit triggerHit;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update()
    {
        if (triggerHit.isCooldown)
        {
            if (conditionalCheck.procedurNum == 4)
            {
                if (triggerHit.objectName.Equals("api"))
                {
                    triggerHit.TimeTotal -= Time.deltaTime;
                    if (triggerHit.TimeTotal < 0)
                    {
                        triggerHit
                            .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                1
                            )
                            .GetComponent<Slider>()
                            .value = triggerHit.i;
                        triggerHit.i++;
                        //Debug.Log("apiTrigger");

                        if (
                            triggerHit.i
                            <= triggerHit
                                .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                    1
                                )
                                .GetComponent<Slider>()
                                .maxValue
                        )
                        {
                            triggerHit
                                .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                    1
                                )
                                .GetComponent<TextSlider>()
                                .text.text = triggerHit.i.ToString();
                            if (
                                triggerHit.i
                                == triggerHit
                                    .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                        1
                                    )
                                    .GetComponent<Slider>()
                                    .maxValue
                            )
                            {
                                triggerHit.isCooldown = false;
                                GetComponent<DragController>().enabled = false;
                                conditionalCheck.CheckCondition();
                            }
                            triggerHit.TimeTotal = triggerHit.tempTime;
                        }
                    }
                }
            }
            else if (conditionalCheck.procedurNum == 11)
            {
                if (triggerHit.objectName.Equals("api"))
                {
                    triggerHit.TimeTotal -= Time.deltaTime;
                    if (triggerHit.TimeTotal < 0)
                    {
                        triggerHit
                            .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                1
                            )
                            .GetComponent<Slider>()
                            .value = triggerHit.i;
                        triggerHit.i++;
                        //Debug.Log("apiTrigger");

                        if (
                            triggerHit.i
                            <= triggerHit
                                .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                    1
                                )
                                .GetComponent<Slider>()
                                .maxValue
                        )
                        {
                            triggerHit
                                .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                    1
                                )
                                .GetComponent<TextSlider>()
                                .text.text = triggerHit.i.ToString();
                            if (
                                triggerHit.i
                                == triggerHit
                                    .transform.parent.transform.parent.transform.parent.transform.GetChild(
                                        1
                                    )
                                    .GetComponent<Slider>()
                                    .maxValue
                            )
                            {
                                triggerHit.isCooldown = false;
                                GetComponent<DragController>().enabled = false;
                                conditionalCheck.CheckCondition();
                            }
                            triggerHit.TimeTotal = triggerHit.tempTime;
                        }
                    }
                }
            }
        }
    }
}
