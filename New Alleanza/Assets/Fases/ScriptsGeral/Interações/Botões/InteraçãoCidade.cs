using UnityEngine;

public class InteraçãoCidade : MonoBehaviour
{
    public GameObject GoCasaHelena;
    public GameObject GoEscadaria;
    public GameObject GoMuseu;

    public GameObject jogador;

    [Header("EntreCenas")]
    float distancia_GoEscadaria;
    float distancia_GoCasaHelena;
    float distancia_GoMuseu;

    private void Start()
    {
        jogador = GameObject.Find("Morgan");
    }

    void Update()
    {
        distancia_GoEscadaria = Vector2.Distance(jogador.transform.position, GoEscadaria.transform.position);
        distancia_GoCasaHelena = Vector2.Distance(jogador.transform.position, GoCasaHelena.transform.position);
        distancia_GoMuseu = Vector2.Distance(jogador.transform.position, GoMuseu.transform.position);

        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas ()
    {
        if (PlayerPrefs.GetInt ("Visitou o castelo", 0) == 1 & distancia_GoCasaHelena < 5)
        {
            GoCasaHelena.SetActive (true);
        }
        else
        {
            GoCasaHelena.SetActive (false);
        }

        if (distancia_GoEscadaria < 5)
        {
            GoEscadaria.SetActive(true);
        }
        else
        {
            GoEscadaria.SetActive(false);
        }

        if (distancia_GoMuseu < 5)
        {
            GoMuseu.SetActive(true);
        }
        else
        {
            GoMuseu.SetActive(false);
        }
    }
}