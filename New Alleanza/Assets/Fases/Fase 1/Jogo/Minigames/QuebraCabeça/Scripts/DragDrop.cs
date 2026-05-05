using UnityEngine;
using UnityEngine.EventSystems;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;
    CanvasGroup colide;

    public RectTransform sombra;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> (); //atribui a posição da peça para a variável "rt"
        colide = GetComponent <CanvasGroup> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {

    }

    public void OnDrag (PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta * 2;
        colide.blocksRaycasts = false;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        colide.blocksRaycasts = true;
    }

    public void OnPointerDown (PointerEventData eventData)
    {

    }
}