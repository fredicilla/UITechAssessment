using UnityEngine;

public class HoverHandController : MonoBehaviour
{
    public RectTransform handImage; // Drag the hand image here

    public void MoveHandTo(RectTransform target)
    {
        // Optional: adjust the offset so it's nicely next to the button
        Vector3 newPosition = target.position;
        newPosition.x -= 80f; // move hand to the left of the button
        handImage.position = newPosition;
    }
}