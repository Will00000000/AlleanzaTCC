using UnityEngine;

public class InteraçãoPraia : MonoBehaviour
{
    GameObject jogador;

    public GameObject botãoCasa;
    public GameObject GoOceano;
    public GameObject Fase3; //Objeto que contém os objetos de acesso à fase 3
    [SerializeField] float distancia_botaoCasa;
    
    void Start ()
    {
        jogador = GameObject.Find("Morgan");
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

        if (PlayerPrefs.GetInt ("Visitou o minigame das caixas", 0) == 1) //se o jogador visitou o minigame das caixas (herança de SceneController)
        {
            Fase3.SetActive(true); //Fase 3 está ativada
        }
        else
        {
            Fase3.SetActive(false); //Fase 3 estão desativa
        }
    }
}