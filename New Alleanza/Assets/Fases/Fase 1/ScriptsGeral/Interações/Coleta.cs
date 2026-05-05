using UnityEngine;

public class Coleta : MonoBehaviour
{
    GameObject jogador;
    [SerializeField] GameObject botaoPeca, peca;
    public float distancia_jogador;

    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update ()
    {
        distancia_jogador = Vector2.Distance(peca.transform.position, jogador.transform.position);

        if (distancia_jogador < 2)
        {
            botaoPeca.SetActive(true);
        }
        else
        {
            botaoPeca.SetActive(false);
        }
    }

    public void Peca ()
    {
        Destroy(gameObject);
    }
}