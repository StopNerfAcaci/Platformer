
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ButtonHovered : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Color normalColor = Color.white;
    private Color hoverColor = Color.green;
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
