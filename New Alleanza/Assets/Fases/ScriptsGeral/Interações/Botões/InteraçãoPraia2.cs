using UnityEngine;

public class InteraçãoPraia2 : MonoBehaviour
{
    GameObject jogador;

    [Header("EntreCenas")]
    public GameObject GoPraia;
    public GameObject GoEscadaria;

    float distancia_GoPraia;
    float distancia_GoEscadaria;

    void Start()
    {
        jogador = GameObject.Find("Morgan");
        InteracaoEntreCenas();
    }

    void Update()
    {
        InteracaoEntreCenas();

        distancia_GoPraia = Vector2.Distance(jogador.transform.position, GoPraia.transform.position);
        distancia_GoEscadaria = Vector2.Distance(jogador.transform.position, GoEscadaria.transform.position);
    }

    private void InteracaoEntreCenas()
    {
        if (distancia_GoPraia < 5)
        {
            GoPraia.SetActive(true);
        }
        else
        {
            GoPraia.SetActive(false);
        }

        if (distancia_GoEscadaria < 5)
        {
            GoEscadaria.SetActive(true);
        }
        else
        {
            GoEscadaria.SetActive(false);
        }
    }
}
