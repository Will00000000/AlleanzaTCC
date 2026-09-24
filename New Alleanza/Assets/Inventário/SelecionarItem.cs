using UnityEngine;
using UnityEngine.UI;

public class SelecionarItem : MonoBehaviour
{
    private Color novaCor; // variável para receber uma cor ou transparência

    public Image spriteSlot; // variável pública para receber o Image do slot 1
    public Image espaçoItem; // variável pública para receber o Image da área onde o item fica na mão rápida

    private void Start() // primeiro frame
    {
        // No ínicio da cena, o espaço do item fica invisível

        spriteSlot = GetComponent<Image>(); // variável do slot recebe o Image do objeto em que está anexado

        novaCor.a = 0f; // a variável da cor recebe transparência 0
        espaçoItem.color = novaCor; // Image da área onde o item fica na mão rápida recebe transparência 0
    }

    public void SelecaoItem () // função para pegar o item do slot para o espaço do item na mão rápida
    {
        // Deixa o novaCor para tornar algo totalmente visível
        novaCor.a = 1f;
        novaCor.r = 1f;
        novaCor.g = 1f;
        novaCor.b = 1f;

        espaçoItem.sprite = spriteSlot.sprite; // espaço do item recebe o sprite que pertence ao slot
        espaçoItem.color = novaCor; // deixa o espaço do item visível
    }
}