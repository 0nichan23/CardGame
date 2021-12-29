using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Droppable : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log(eventData.pointerDrag.name + " was dropped to " + gameObject.name);
        Draggable d =  eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parenttoreturnto = this.transform;
        }
        CardDisplay card = eventData.pointerDrag.GetComponent<CardDisplay>();
        if (card != null)
        {
            CombatManager.Instance.PlayCard(card);
        }        
    }
}
