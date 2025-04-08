using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ItemSlot : MonoBehaviour, IDropHandler
{

    public Transform tick;
    [Header("Akt6")]
    public string jenisAnodKatod;
    // Start is called before the first frame update
    void Start()
    {
        tick = transform.GetChild(0).GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnDrop(PointerEventData eventData)
    {
        if (!SceneManager.GetActiveScene().Equals("akt6"))
        {

            //Debug.Log("stuck");
            eventData.pointerDrag.transform.SetParent(transform);
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.transform.localPosition = new Vector3(0, 0, 0);


            tick.gameObject.SetActive(true);

            eventData.pointerDrag.transform.GetComponent<DragController>().enabled = false;

        }
        else
        {
            Debug.Log("stuck");

        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (jenisAnodKatod == "anod")
        {
            Debug.Log("anod");
            if (collision.name.Equals("anodElektrod"))
            {
                collision.transform.GetComponent<DragController>().enabled = false;
                //Debug.Log("stuck");
                collision.transform.SetParent(transform);
                //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                collision.transform.localPosition = new Vector3(0, 0, 0);


                tick.gameObject.SetActive(true);

                //transform.gameObject.SetActive(false);


            }
        }
        else if (jenisAnodKatod == "katod")
        {
            Debug.Log("katod");
            if (collision.name.Equals("katodElektrod"))
            {
                collision.transform.GetComponent<DragController>().enabled = false;
                //Debug.Log("stuck");
                collision.transform.SetParent(transform);
                //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                collision.transform.localPosition = new Vector3(0, 0, 0);


                tick.gameObject.SetActive(true);

                //transform.gameObject.SetActive(false);


            }
        }
    }


}
