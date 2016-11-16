using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public Draggable.Type typeOfCard = Draggable.Type.MONSTER;

	public void OnPointerEnter(PointerEventData eventData)
	{
		if (eventData.pointerDrag == null)
			return;
		Draggable card = eventData.pointerDrag.GetComponent<Draggable> ();
		if (card != null) 
		{
			if(typeOfCard == card.typeOfCard)
				card.placeholderParent = this.transform;
		}
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		if (eventData.pointerDrag == null)
			return;
		Draggable card = eventData.pointerDrag.GetComponent<Draggable> ();
		if (card != null && card.placeholderParent==this.transform) 
		{
			if(typeOfCard == card.typeOfCard)
				card.placeholderParent = card.parentToReturnTo;
		}
	}

	public void OnDrop(PointerEventData eventData)
	{
		Draggable card = eventData.pointerDrag.GetComponent<Draggable> ();
		if (card != null) 
		{
			if(typeOfCard == card.typeOfCard)
				card.parentToReturnTo = this.transform;
		}
	}
}
