using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterVolumeController : MonoBehaviour
{
    public List<Transform> waterLevel;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    public void AddLevel()
    {
        for (int i = 0; i < waterLevel.Count; i++)
        {
            if (!waterLevel[i].gameObject.activeSelf)
            {
                waterLevel[i].gameObject.SetActive(true);
                break;
            }

            if (waterLevel[i].gameObject.activeSelf) { }
        }
    }
}
