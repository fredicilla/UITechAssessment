using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems; // Required for pointer events

public class ButtonTextVertexHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Color normalColor = Color.black; // Default vertex color
    [SerializeField] private Color hoverColor = Color.yellow; // Hover vertex color
    private Text buttonText; // Reference to the Text component

    void Start()
    {
        buttonText = GetComponentInChildren<Text>();
        if (buttonText == null)
        {
            Debug.LogError("No Text component found on button children!");
            return;
        }
        UpdateVertexColors(normalColor); // Set initial color
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (buttonText != null)
        {
            UpdateVertexColors(hoverColor); // Change vertex color on hover
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (buttonText != null)
        {
            UpdateVertexColors(normalColor); // Revert vertex color
        }
    }

    private void UpdateVertexColors(Color color)
    {
        if (buttonText != null)
        {
            buttonText.color = color; // Try standard color first
            buttonText.CrossFadeColor(color, 0f, true, true); // Force update
        }
    }
}