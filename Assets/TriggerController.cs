using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour
{
    public List<Transform> toDisplay;
    public List<Transform> toHide;

    public bool AllInactive;
    public int turnCount;

    [Header("Akt4-3")]
    public List<WaterVolumeController> waterVolumeController;
    public List<Transform> buttonsContinue;

    [Header("Akt4-6")]
    public List<WaterVolumeController> waterVolumeController2;
    public List<Transform> buttonsContinue2;

    // Start is called before the first frame update
    void Start()
    {
        // turnCount = 0;
    }

    // Update is called once per frame
    void Update() { }

    public void CheckItemAct4_3()
    {
        StartCoroutine(checkItemAct4_3());
    }

    public void CheckItemAct4_6()
    {
        StartCoroutine(checkItemAct4_6());
    }

    IEnumerator checkItemAct4_6()
    {
        for (int i = 0; i < toHide.Count; i++)
        {
            if (toHide[i].gameObject.activeSelf)
            {
                AllInactive = false;
            }
            else
            {
                AllInactive = true;
            }
        }

        if (AllInactive)
        {
            toDisplay[turnCount].gameObject.SetActive(false);
            turnCount++;
            if (turnCount < 5)
            {
                toDisplay[turnCount].gameObject.SetActive(true);
                waterVolumeController2[0].AddLevel();

                yield return new WaitForSeconds(1.4f);
                //redisplay to hide
                toHide[0].gameObject.SetActive(true);
            }
            else
            {
                buttonsContinue2[0].gameObject.SetActive(true);
                buttonsContinue2[1].gameObject.SetActive(true);
            }
        }
    }

    IEnumerator checkItemAct4_3()
    {
        for (int i = 0; i < toHide.Count; i++)
        {
            if (toHide[i].gameObject.activeSelf)
            {
                AllInactive = false;
            }
            else
            {
                AllInactive = true;
            }
        }

        if (AllInactive)
        {
            toDisplay[turnCount].gameObject.SetActive(false);
            turnCount++;
            if (turnCount < 4)
            {
                toDisplay[turnCount].gameObject.SetActive(true);
                waterVolumeController[0].AddLevel();
                waterVolumeController[1].AddLevel();
                yield return new WaitForSeconds(1.4f);
                //redisplay to hide
                toHide[0].gameObject.SetActive(true);
                toHide[1].gameObject.SetActive(true);
            }
            else
            {
                buttonsContinue[0].gameObject.SetActive(true);
                buttonsContinue[1].gameObject.SetActive(true);
            }
        }
    }
}
