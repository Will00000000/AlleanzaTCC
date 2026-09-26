using UnityEngine;
using UnityEngine.UI;

public class MaoRapida : MonoBehaviour
{
    private Image maoRapida;

    public SelecionarItem selecionarItem;

    Color novaCor;

    public Image espacoItem;

    private void Start()
    {
        maoRapida = GetComponent<Image>();
    }

    public void UsarItem () // tirar o item da m�o r�pida e usar ele na cena
    {
        maoRapida.sprite = null;
        novaCor.a = 0f;
        maoRapida.color = novaCor;
    }
}