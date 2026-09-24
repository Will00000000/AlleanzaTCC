using UnityEngine;
using UnityEngine.UI;

public class MaoRapida : MonoBehaviour
{
    private Image espaçoItem; // variável privada que recebe a imagem do espaço do item

    public SelecionarItem selecionarItem; // variável pública que recebe o script de SelecionarItem (pegar o item do inventário e jogar na mão rápida)

    Color novaCor; // variável de cor

    private void Start()
    {
        espaçoItem = GetComponent<Image>(); // espaço do item recebe o Image do objeto em que está anexado
    }

    public void UsarItem () // tirar o item da mão rápida e usar ele na cena
    {
        espaçoItem.sprite = null; // remove o sprite da imagem do item

        novaCor.a = 0f; // zera a transparência da cor
        espaçoItem.color = novaCor; // usa a variável de transparência e deixa a imagem do item transparente
    }
}