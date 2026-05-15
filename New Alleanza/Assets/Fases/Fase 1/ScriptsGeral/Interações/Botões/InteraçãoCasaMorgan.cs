using UnityEngine;

public class InteraçãoCasaMorgan : MonoBehaviour
{
    GameObject jogador;

    public GameObject mochila, mochilaInteracao;
    public GameObject mapa, mapaInteracao;
    public GameObject chave, chaveInteracao;
    public GameObject botaoSair;
    [SerializeField] float distanciaMochila, distanciaMapa, distanciaBotao, distanciaChave;

    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update()
    {
        InteracaoColeta();
        InteracaoEstruturas();

        distanciaMochila = Vector2.Distance(jogador.transform.position, mochila.transform.position);
        distanciaMapa = Vector2.Distance(jogador.transform.position, mapa.transform.position);
        distanciaBotao = Vector2.Distance(jogador.transform.position, botaoSair.transform.position);
        distanciaChave = Vector2.Distance(jogador.transform.position, chave.transform.position);
    }

    private void InteracaoColeta()
    {
        if (distanciaMochila < 2)
        {
            mochilaInteracao.SetActive(true);
        }
        else
        {
            mochilaInteracao.SetActive(false);
        }

        if (distanciaMapa < 2)
        {
            mapaInteracao.SetActive(true);
        }
        else
        {
            mapaInteracao.SetActive(false);
        }

        if (distanciaChave < 4)
        {
            chaveInteracao.SetActive(true);
        }
        else
        {  
            chaveInteracao.SetActive(false);
        }
    }

    private void InteracaoEstruturas()
    {
        if (distanciaBotao < 2)
        {
            botaoSair.SetActive(true);
        }
        else
        {
            botaoSair.SetActive(false);
        }
    }
}