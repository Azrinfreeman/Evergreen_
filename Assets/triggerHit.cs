using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggerHit : MonoBehaviour
{
    public ConditionalCheck conditionalCheck;

    [SerializeField]
    public string objectName;

    [SerializeField]
    public float i = 0.1f;

    public float TimeTotal;
    public float tempTime;

    public bool isCooldown;

    // Start is called before the first frame update
    void Start()
    {
        tempTime = TimeTotal;
        objectName = GetComponent<Transform>().transform.name;
    }

    // Update is called once per frame
    void Update() { }

    public void Procedur13()
    {
        GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
        i += 10;
        //Debug.Log("apiTrigger");

        if (i <= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
        {
            if (i > 40 && i < 60)
            {
                GameObject
                    .Find("Petri")
                    .GetComponent<Transform>()
                    .GetChild(0)
                    .GetComponent<CanvasGroup>()
                    .alpha = 0.5f;
            }
            else if (i > 60)
            {
                GameObject
                    .Find("Petri")
                    .GetComponent<Transform>()
                    .GetChild(0)
                    .GetComponent<CanvasGroup>()
                    .alpha = 1f;
            }
            GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text = i.ToString();
            if (i == GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
            {
                isCooldown = false;

                conditionalCheck.CheckCondition();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().name.Equals("akt3"))
        {
            if (conditionalCheck.procedurNum == 2)
            {
                if (objectName.Equals("api"))
                {
                    transform
                        .parent.transform.parent.transform.GetChild(1)
                        .gameObject.SetActive(true);
                    //Debug.Log("onEnter");
                }
            }

            if (conditionalCheck.procedurNum == 5)
            {
                if (objectName.Equals("larutanKultur"))
                {
                    transform
                        .parent.transform.parent.transform.GetChild(1)
                        .gameObject.SetActive(true);
                    //Debug.Log("onEnter");
                }
            }
            if (conditionalCheck.procedurNum == 6)
            {
                if (objectName.Equals("collider"))
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i += 10;

                    if (i > 60)
                        transform.parent.GetComponent<CanvasGroup>().alpha = 1f;

                    if (i >= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        i = 100;
                        conditionalCheck.CheckCondition();
                    }
                    GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text = i.ToString(
                        "00"
                    );
                    Debug.Log("zigzag tuch");
                }
            }
            if (conditionalCheck.procedurNum == 7)
            {
                if (objectName.Equals("collider"))
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i += 10;

                    if (i > 60)
                        transform.parent.GetComponent<CanvasGroup>().alpha = 1f;

                    if (i >= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        i = 100;
                        conditionalCheck.CheckCondition();
                    }
                    GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text = i.ToString(
                        "00"
                    );
                    Debug.Log("zigzag tuch");
                }
            }
            if (conditionalCheck.procedurNum == 8)
            {
                if (objectName.Equals("collider"))
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i += 10;

                    if (i > 60)
                        transform.parent.GetComponent<CanvasGroup>().alpha = 1f;

                    if (i >= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        i = 100;
                        conditionalCheck.CheckCondition();
                    }
                    GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text = i.ToString(
                        "00"
                    );
                    Debug.Log("zigzag tuch");
                }
            }

            if (conditionalCheck.procedurNum == 9)
            {
                if (objectName.Equals("collider"))
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i += 10;

                    if (i > 60)
                        transform.parent.GetComponent<CanvasGroup>().alpha = 1f;

                    if (i >= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        i = 100;
                        conditionalCheck.CheckCondition();
                    }
                    GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text = i.ToString(
                        "00"
                    );
                    Debug.Log("zigzag tuch");
                }
            }
        }
        else if (SceneManager.GetActiveScene().name.Equals("akt7"))
        {
            if (conditionalCheck.procedurNum == 1)
            {
                if (other.gameObject.tag == "action")
                {
                    Debug.Log("actionproduct");
                }
            }
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().name.Equals("akt3"))
        {
            if (conditionalCheck.procedurNum == 3)
            {
                if (objectName.Equals("api"))
                {
                    TimeTotal -= Time.deltaTime;
                    if (TimeTotal < 0)
                    {
                        transform
                            .parent.transform.parent.transform.parent.transform.GetChild(1)
                            .GetComponent<Slider>()
                            .value = i;
                        i++;
                        //Debug.Log("apiTrigger");

                        if (
                            i
                            <= transform
                                .parent.transform.parent.transform.parent.transform.GetChild(1)
                                .GetComponent<Slider>()
                                .maxValue
                        )
                        {
                            transform
                                .parent.transform.parent.transform.parent.transform.GetChild(1)
                                .GetComponent<TextSlider>()
                                .text.text = i.ToString();
                            if (
                                i
                                == transform
                                    .parent.transform.parent.transform.parent.transform.GetChild(1)
                                    .GetComponent<Slider>()
                                    .maxValue
                            )
                            {
                                isCooldown = false;

                                conditionalCheck.CheckCondition();
                            }
                        }

                        TimeTotal = tempTime;
                    }
                }
            }

            if (conditionalCheck.procedurNum == 5)
            {
                if (objectName.Equals("larutanKultur"))
                {
                    TimeTotal -= Time.deltaTime;
                    if (TimeTotal < 0)
                    {
                        GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                        i++;
                        //Debug.Log("apiTrigger");

                        if (i <= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                        {
                            GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text =
                                i.ToString();
                            if (i == GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                            {
                                isCooldown = false;

                                conditionalCheck.CheckCondition();
                            }
                        }

                        TimeTotal = tempTime;
                    }
                }
            }

            if (conditionalCheck.procedurNum == 10)
            {
                if (objectName.Equals("api"))
                {
                    TimeTotal -= Time.deltaTime;
                    if (TimeTotal < 0)
                    {
                        GameObject.Find("SterilSlider").GetComponent<Slider>().value = i;
                        i++;
                        //Debug.Log("apiTrigger");

                        if (i <= GameObject.Find("SterilSlider").GetComponent<Slider>().maxValue)
                        {
                            GameObject.Find("SterilSlider").GetComponent<TextSlider>().text.text =
                                i.ToString();
                            if (
                                i == GameObject.Find("SterilSlider").GetComponent<Slider>().maxValue
                            )
                            {
                                isCooldown = false;

                                conditionalCheck.CheckCondition();
                            }
                        }

                        TimeTotal = tempTime;
                    }
                }
            }
        }

        if (conditionalCheck.procedurNum == 12)
        {
            if (objectName.Equals("larutanKultur"))
            {
                TimeTotal -= Time.deltaTime;
                if (TimeTotal < 0)
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i++;
                    //Debug.Log("apiTrigger");

                    if (i <= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text =
                            i.ToString();
                        if (i == GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                        {
                            isCooldown = false;

                            conditionalCheck.CheckCondition();
                        }
                    }

                    TimeTotal = tempTime;
                }
            }
        }
        if (conditionalCheck.procedurNum == 14)
        {
            if (objectName.Equals("circle"))
            {
                TimeTotal -= Time.deltaTime;
                if (TimeTotal < 0)
                {
                    GameObject.Find("TempSlider").GetComponent<Slider>().value = i;
                    i += 5;
                    //Debug.Log("apiTrigger");

                    if (i <= GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                    {
                        GameObject.Find("TempSlider").GetComponent<TextSlider>().text.text =
                            i.ToString();
                        if (i == GameObject.Find("TempSlider").GetComponent<Slider>().maxValue)
                        {
                            isCooldown = false;

                            conditionalCheck.CheckCondition();
                        }
                    }

                    TimeTotal = tempTime;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (SceneManager.GetActiveScene().name.Equals("akt3"))
        {
            if (conditionalCheck.procedurNum == 4)
            {
                if (objectName.Equals("api"))
                {
                    //rujuk SuhuBilikControl.cs
                    isCooldown = true;
                }
            }
            if (conditionalCheck.procedurNum == 5)
            {
                if (objectName.Equals("larutanKultur"))
                {
                    //rujuk SuhuBilikControl.cs
                    isCooldown = true;
                }
            }

            if (conditionalCheck.procedurNum == 11)
            {
                if (objectName.Equals("api"))
                {
                    //rujuk SuhuBilikControl.cs
                    isCooldown = true;
                }
            }
        }
    }
}
