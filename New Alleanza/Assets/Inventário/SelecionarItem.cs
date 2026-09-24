using UnityEngine;
using UnityEngine.UI;

public class SelecionarItem : MonoBehaviour
{
    private Color novaCor;

    [HideInInspector] public Image spriteSlot;
    public Image espaçoItem;

    private void Start()
    {
        spriteSlot = GetComponent<Image>();

        novaCor.a = 0f;
        espaçoItem.color = novaCor;
    }

    public void SelecaoItem ()
    {
        novaCor.a = 1f;
        novaCor.r = 1f;
        novaCor.g = 1f;
        novaCor.b = 1f;

        espaçoItem.sprite = spriteSlot.sprite;
        espaçoItem.color = novaCor;
    }
}