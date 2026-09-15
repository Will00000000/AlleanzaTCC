using UnityEngine;
using UnityEngine.UI;

public class MaoRapida : MonoBehaviour
{
    private Image maoRapida;

    Color novaCor;

    private void Start()
    {
        maoRapida = GetComponent<Image>();
    }

    public void UsarItem ()
    {
        maoRapida.sprite = null;
        novaCor.a = 0f;
        maoRapida.color = novaCor;
    }
}