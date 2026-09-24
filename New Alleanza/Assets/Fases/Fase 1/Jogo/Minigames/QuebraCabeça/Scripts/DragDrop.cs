using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    RectTransform rt;
    CanvasGroup colide;
    public Canvas canvasMontagem;

    public RectTransform sombra;

    Color novaCor;

    private void Awake ()
    {
        rt = GetComponent <RectTransform> (); //atribui a posição da peça para a variável "rt"
        colide = GetComponent <CanvasGroup> ();
    }

    public void OnBeginDrag (PointerEventData eventData)
    {
        MudarCorPeca();
    }

    public void OnDrag (PointerEventData eventData)
    {
        rt.anchoredPosition += eventData.delta / canvasMontagem.scaleFactor;
        colide.blocksRaycasts = false;

        eventData.pointerDrag.GetComponent<Image>().color = novaCor;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        colide.blocksRaycasts = true;
    }

    public void OnPointerDown (PointerEventData eventData)
    {

    }

    private void MudarCorPeca ()
    {
        novaCor.r = 1;
        novaCor.g = 1;
        novaCor.b = 1;
        novaCor.a = 1;

        Debug.Log("novaCor fica branco");
    }
}