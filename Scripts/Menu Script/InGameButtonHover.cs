using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;

public class InGameButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    private Color normalColor = Color.white;
    private Color hoverColor = Color.yellow;
    private TMP_Text buttonText;
    void Start()
    {
        buttonText = GetComponentInChildren<TMP_Text>();
        normalColor = buttonText.color;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        buttonText.color = hoverColor;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        buttonText.color = normalColor;
    }
}
