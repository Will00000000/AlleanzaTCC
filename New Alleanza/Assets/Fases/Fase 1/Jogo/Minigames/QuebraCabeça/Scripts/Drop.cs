using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drop : MonoBehaviour, IDropHandler
{
    RectTransform posicaoSombra; //acessar a posição da sombra que recebeu o drop
    public bool correta; //variável que diz se a peça conectada é a correta ou não

    DragDrop corPeca, peca;

    DragDrop arrastar; //pega o script de arrastar peças

    Color novaCor;

    void Start()
    {
        posicaoSombra = GetComponent<RectTransform>(); //atribui a posição da sombra à variável "posicaoSombra"
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;

            gameObject.GetComponent<Image>().raycastTarget = false;
            eventData.pointerDrag.GetComponent<Image>().raycastTarget = false;

            if (eventData.pointerDrag.gameObject.tag != gameObject.tag) //se o encaixe estiver incorreto...
            {
                correta = false; //a peça está incorreta

                novaCor.r = 1f;
                novaCor.g = 0f;
                novaCor.b = 0f;
                novaCor.a = 1f;

                eventData.pointerDrag.GetComponent<Image>().color = novaCor;

                eventData.pointerDrag.GetComponent<Image>().raycastTarget = true;
                gameObject.GetComponent<Image>().raycastTarget = true;
            }
            else
            {
                correta = true; //a peça está correta

                novaCor.r = 1f;
                novaCor.g = 1f;
                novaCor.b = 1f;
                novaCor.a = 1f;
                eventData.pointerDrag.GetComponent <Image>().color = novaCor;

                eventData.pointerDrag.GetComponent<Image>().raycastTarget = false;
            }
        }
    }
}