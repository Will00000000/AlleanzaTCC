using UnityEngine;

public class InteraçãoMuseu : MonoBehaviour
{
    GameObject jogador;

    public GameObject GoQuebraCabeça;
    public GameObject GoCidade;

    [Header("EntreCenas")]
    float distancia_GoQuebraCabeça;
    float distancia_GoCidade;

    private void Start ()
    {
        jogador = GameObject.Find("Morgan");
    }

    private void Update()
    {
        distancia_GoQuebraCabeça = Vector2.Distance (jogador.transform.position, GoQuebraCabeça.transform.position);
        distancia_GoCidade = Vector2.Distance(jogador.transform.position, GoCidade.transform.position);

        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas()
    {
        if (distancia_GoQuebraCabeça < 5)
        {
            GoQuebraCabeça.SetActive(true);
        }
        else
        {
            GoQuebraCabeça.SetActive(false);
        }

        if (distancia_GoCidade < 5)
        {
            GoCidade.SetActive (true);
        }
        else
        {
            GoCidade.SetActive (false);
        }
    }
}