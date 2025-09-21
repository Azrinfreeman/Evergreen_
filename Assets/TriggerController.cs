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

    // Start is called before the first frame update
    void Start()
    {
        turnCount = 0;
    }

    // Update is called once per frame
    void Update() { }

    public void CheckItemAct4_3()
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
            toDisplay[turnCount].gameObject.SetActive(true);
            waterVolumeController[0].AddLevel();
            waterVolumeController[1].AddLevel();
        }
    }
}
