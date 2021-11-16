using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parenttoreturnto = null;
    public void OnBeginDrag(PointerEventData eventData)
    {
        parenttoreturnto = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Debug.Log("stopped draggin");
        this.transform.SetParent(parenttoreturnto);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }


}
