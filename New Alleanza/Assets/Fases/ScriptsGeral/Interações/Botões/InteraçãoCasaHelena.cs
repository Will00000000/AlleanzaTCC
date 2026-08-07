using UnityEngine;

public class InteraçãoCasaHelena : MonoBehaviour
{
    GameObject jogador;

    public GameObject GoCidade;
    public GameObject GoMinigameCaixa;

    [Header("EntreCenas")]
    float distancia_GoCidade;
    float distancia_GoMinigameCaixa;

    private void Start()
    {
        jogador = GameObject.Find("Melissa");
    }

    private void Update()
    {
        distancia_GoCidade = Vector2.Distance(jogador.transform.position, GoCidade.transform.position);
        distancia_GoMinigameCaixa = Vector2.Distance(jogador.transform.position, GoMinigameCaixa.transform.position);

        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas()
    {
        if (distancia_GoCidade < 5)
        {
            GoCidade.SetActive(true);
        }
        else
        {
            GoCidade.SetActive(false);
        }

        if (distancia_GoMinigameCaixa < 5)
        {
            GoMinigameCaixa.SetActive(true);
        }
        else
        {
            GoMinigameCaixa.SetActive(false);
        }
    }
}