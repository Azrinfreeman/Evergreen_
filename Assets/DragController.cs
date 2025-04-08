using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragController : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler
{
    [SerializeField] private string objectName;

    [SerializeField]
    private Canvas canvas;

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (objectName == null)
        {
            //  Debug.Log("OnBeginDrag");
            GetComponent<CanvasGroup>().alpha = .6f;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            //        GameObject.Find("cartoon").GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (objectName.Equals("Dawai"))
        {
            //  Debug.Log("OnBeginDrag");
            GetComponent<CanvasGroup>().alpha = 1f;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            //        GameObject.Find("cartoon").GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else if (objectName.Equals("katod"))
        {
            //  Debug.Log("OnBeginDrag");
            GetComponent<CanvasGroup>().alpha = 1f;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            //        GameObject.Find("cartoon").GetComponent<AudioSource>().Play();
            GetComponent<BoxCollider2D>().enabled = true;
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //Debug.Log("OnDrag");
        GetComponent<RectTransform>().anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //   Debug.Log("OnEndDrag");
        GetComponent<CanvasGroup>().alpha = 1f;
        GetComponent<CanvasGroup>().blocksRaycasts = true;

        GetComponent<BoxCollider2D>().enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update() { }
}
