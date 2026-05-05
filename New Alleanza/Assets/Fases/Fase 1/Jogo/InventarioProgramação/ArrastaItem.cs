/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //interface
using UnityEngine.EventSystems; //códigos de captura de eventos, como o arrastar

public class ArrastaItem : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler //começo, meio e fim de um arrasto
{
    [HideInInspector] public Transform parentDepoisArrastar; //para esconder a variável do Inspector, mas ao mesmo tempo a deixar pública para qualquer outra classe
    public Image image; //acessar a aparência do item

    public void OnBeginDrag(PointerEventData eventData) //função que é executada quando o arrasto começa, ele espera as informações do cursor
    {
        parentDepoisArrastar = transform.parent; //logo no início, o pai do item arrastado é armazenado nessa variável
        transform.SetParent(transform.root); //o item fica no topo da hierarquia para ser vizualisado acima de todos os objetos em cena
        transform.SetAsLastSibling(); //o item fica na frente de todos os objetos do tipo UI
        image.raycastTarget = false; //desativa qualquer interação que o item pode receber
    }

    public void OnDrag(PointerEventData eventData) //durante o arrasto
    {
        transform.position = Input.mousePosition; //a posição do item acompanha a posição do mouse
    }

    public void EndDrag(PointerEventData eventData) //ao soltar o item
    {
        if (EventSystem.current.IsPointerOverGameObject()) //verifica se o item está acima de outro objeto UI ou em qualquer lugar da tela
        {
            GameObject objetoAbaixo = eventData.pointerEnter;

            if (objetoAbaixo != null && objetoAbaixo.transform.parent != null && objetoAbaixo.transform.parent.CompareTag("SlotInventario"))
            {
                parentDepoisArrastar = objetoAbaixo.transform;
            }
        }

        transform.SetParent(parentDepoisArastar);
        image.raycastTarget = true;
    }
}*/