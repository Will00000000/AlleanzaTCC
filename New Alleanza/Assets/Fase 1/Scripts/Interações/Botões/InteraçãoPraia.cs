using UnityEngine;

public class InteraçãoPraia : MonoBehaviour
{
    GameObject jogador;

    public GameObject botãoCasa;
    [SerializeField] float distancia_botaoCasa;
    
    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update ()
    {
        InteracaoEstruturas();

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
}