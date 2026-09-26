using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SelecionarItem : MonoBehaviour
{
    private Color novaCor;

    public Image spriteSlot;
    public Image espacoItem;

    private void Start()
    {
        spriteSlot = GetComponent<Image>();

        novaCor.a = 0f;
        espacoItem.color = novaCor;

    }

    public void SelecaoItem ()
    {
        novaCor.a = 1f;
        novaCor.r = 1f;
        novaCor.g = 1f;
        novaCor.b = 1f;

        espacoItem.sprite = spriteSlot.sprite;
        espacoItem.color = novaCor;
    }
}