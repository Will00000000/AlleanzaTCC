using UnityEngine;

public class InteraçãoPraia : MonoBehaviour
{
    GameObject jogador;

    public GameObject Fase3; //Objeto que contém os objetos de acesso à fase 3

    [Header("EntreCenas")]
    public GameObject coletarPeça;
    public GameObject GoPraia2;
    public GameObject GoOceano;
    public GameObject GoCasa;
    public GameObject GoRefúgio;

    float distancia_GoCasa;
    float distancia_GoPraia2;
    float distancia_GoOceano;
    float distancia_GoRefúgio;
    float distancia_coletarPeça;

    void Start ()
    {
        jogador = GameObject.Find("Morgan");
    }

    void Update ()
    {
        InteracaoEntreCenas();

        distancia_GoCasa = Vector2.Distance(jogador.transform.position, GoCasa.transform.position);
        distancia_GoPraia2 = Vector2.Distance(jogador.transform.position, GoPraia2.transform.position);
        distancia_GoOceano = Vector2.Distance(jogador.transform.position, GoOceano.transform.position);
        distancia_GoRefúgio = Vector2.Distance(jogador.transform.position, GoRefúgio.transform.position);
        distancia_coletarPeça = Vector2.Distance(jogador.transform.position, coletarPeça.transform.position);
    }

    private void InteracaoEntreCenas ()
    {
        if (PlayerPrefs.GetInt ("Visitou quebra-cabeça", 0) == 1 & distancia_GoOceano < 5)
        {
            GoOceano.SetActive(true);
        }
        else
        {
            GoOceano.SetActive(false);
        }

        if (PlayerPrefs.GetInt ("Visitou o minigame das caixas", 0) == 1) //se o jogador visitou o minigame das caixas (herança de SceneController)
        {
            Fase3.SetActive(true); //Fase 3 está ativada
        }
        else
        {
            Fase3.SetActive(false); //Fase 3 está desativada
        }

        if (distancia_GoCasa < 5)
        {
            GoCasa.SetActive(true);
        }
        else
        {
            GoCasa.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Coletou peça", 0) == 1 && distancia_GoPraia2 < 5) //IR PARA A PRAIA 2
        {
            GoPraia2.SetActive(true);
        }
        else
        {
            GoPraia2.SetActive(false);
        }

        if (distancia_GoRefúgio < 5)
        {
            GoRefúgio.SetActive(true);
        }
        else
        {
            GoRefúgio.SetActive(false);
        }

        if (distancia_coletarPeça < 5)
        {
            coletarPeça.SetActive(true);
        }
        else
        {
            coletarPeça.SetActive(false);
        }
    }
}