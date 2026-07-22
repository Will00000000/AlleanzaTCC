using UnityEngine;

public class InteraçãoPraia : MonoBehaviour
{
    GameObject jogador;

    public GameObject botãoCasa;
    public GameObject GoOceano;
    [SerializeField] float distancia_botaoCasa;
    
    void Start ()
    {
        jogador = GameObject.Find("Jogador");
        InteracaoEntreCenas();
    }

    void Update ()
    {
        InteracaoEstruturas();
        InteracaoEntreCenas();

        distancia_botaoCasa = Vector2.Distance(jogador.transform.position, botãoCasa.transform.position);
    }

    private void InteracaoEstruturas()
    {
        if (distancia_botaoCasa < 2)
        {
            botãoCasa.SetActive(true);
        }
        else
        {
            botãoCasa.SetActive(false);
        }
    }

    private void InteracaoEntreCenas ()
    {
        if (PlayerPrefs.GetInt ("Visitou quebra-cabeça", 0) == 1)
        {
            GoOceano.SetActive(true);
        }
        else
        {
            GoOceano.SetActive(false);
        }
    }
}