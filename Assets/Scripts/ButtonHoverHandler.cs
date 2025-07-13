using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonHoverHandler : MonoBehaviour, IPointerEnterHandler
{
    public HoverHandController hoverController;

    public void OnPointerEnter(PointerEventData eventData)
    {
        hoverController.MoveHandTo(transform as RectTransform);
    }
}
