using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class triggerAfter : MonoBehaviour
{
    public CanvasGroup itemToAppear;
    public TextMeshProUGUI textPercentage;

    public List<Transform> actionButtons;

    public List<Transform> thingsToRemove;

    [Space]
    public TriggerController triggerController;

    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (SceneManager.GetActiveScene().name == "akt4")
        {
            if (collision.gameObject.tag == "action")
            {
                itemToAppear.alpha += 0.09f;
                textPercentage.text = (itemToAppear.alpha * 100).ToString("00") + "%";
                Debug.Log("ItemTouch");

                if (itemToAppear.alpha == 1)
                {
                    collision.GetComponent<RectTransform>().localRotation = Quaternion.Euler(
                        0,
                        0,
                        0
                    );
                    for (int i = 0; i < actionButtons.Count; i++)
                    {
                        actionButtons[i].gameObject.SetActive(true);
                    }
                    for (int i = 0; i < thingsToRemove.Count; i++)
                    {
                        thingsToRemove[i].gameObject.SetActive(false);
                    }
                }
            }

            if (collision.gameObject.name == "plasmid")
            {
                transform.gameObject.SetActive(false);
                triggerController.CheckItemAct4_3();
            }
            else if (collision.gameObject.name == "plasmid2")
            {
                transform.gameObject.SetActive(false);
                triggerController.CheckItemAct4_6();
            }
        }
    }
}
