using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Joystick : MonoBehaviour, IDragHandler ,IEndDragHandler
{
    Vector2 parent;
    Vector2 unlimitedLocalPosition;
    Vector2 clamp;
    public Vector2 unlimitedLocalPositionEnd;
    Vector2 size;
    void Start()
    {
        transform.TryGetComponent(out RectTransform rectTransform);
        size = rectTransform.rect.size;
    }

    public void OnDrag(PointerEventData mouse)
    {
        parent = transform.parent.position;
        unlimitedLocalPosition = (parent - mouse.position) / (-2.25f);

        clamp = new Vector2(
            Mathf.Abs(unlimitedLocalPosition.normalized.x),
            Mathf.Abs(unlimitedLocalPosition.normalized.y)
            ) * (size / 1.5f);

        unlimitedLocalPositionEnd = new Vector2(
            Mathf.Clamp(unlimitedLocalPosition.x, -clamp.x, clamp.x),
            Mathf.Clamp(unlimitedLocalPosition.y, -clamp.y, clamp.y)
            ) * 2f;

        transform.localPosition = unlimitedLocalPositionEnd;
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        transform.localPosition = Vector2.zero;
        unlimitedLocalPositionEnd = Vector2.zero;
    }
}
