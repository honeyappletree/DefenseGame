using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Joystick : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Image joystickBack;
    private Image joystick;
    private Vector2 touchPosition;

    public void OnDrag(PointerEventData eventData)
    {
        touchPosition = Vector2.zero;

        if(RectTransformUtility.ScreenPointToLocalPointInRectangle(
            joystickBack.rectTransform, eventData.position, eventData.pressEventCamera, out touchPosition))
        {
            touchPosition.x = (touchPosition.x / joystickBack.rectTransform.sizeDelta.x);
            touchPosition.y = (touchPosition.y / joystickBack.rectTransform.sizeDelta.y);
            touchPosition = new Vector2(touchPosition.x * 4f - 1, touchPosition.y * 4f - 1);
            touchPosition = (touchPosition.magnitude > 1) ? touchPosition.normalized : touchPosition;
            joystick.rectTransform.anchoredPosition = new Vector2(
                touchPosition.x * joystickBack.rectTransform.sizeDelta.x / 4f,
                touchPosition.y * joystickBack.rectTransform.sizeDelta.y / 4f);

        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        joystick.rectTransform.anchoredPosition = Vector2.zero;
        touchPosition = Vector2.zero;
    }

    void Awake()
    {
        joystickBack = GetComponent<Image>();
        joystick = transform.GetChild(0).GetComponent<Image>();
    }

    public float Horizontal()
    {
        return touchPosition.x;
    }

    public float Vertical()
    {
        return touchPosition.y;
    }
}
