using UnityEngine;

public class InteraçãoCasaMorgan : MonoBehaviour
{
    GameObject jogador;

    public GameObject mochila, mochilaInteracao;
    public GameObject mapa, mapaInteracao;
    public GameObject botaoSair;
    [SerializeField] float distanciaMochila, distanciaMapa, distanciaBotao;

    void Start ()
    {
        jogador = GameObject.Find("Jogador");
    }

    void Update()
    {
        InteracaoColeta();
        InteracaoEntreCenas();

        // --- ADAPTADO COM CHECAGEM DE SEGURANÇA ---
        // Só calcula a distância se o jogador existir e o item NÃO tiver sido pego ainda
        if (jogador != null)
        {
            // Se a mochila ainda NÃO foi pega e o objeto existe na cena
            if (!GameManager.MorganPegouMochila && mochila != null && mochila.activeSelf)
            {
                distanciaMochila = Vector2.Distance(jogador.transform.position, mochila.transform.position);
            }
            else
            {
                distanciaMochila = 999f; // Define uma distância alta para sumir com o balão de interação
            }

            // Se o mapa ainda NÃO foi pego e o objeto existe na cena
            if (!GameManager.MorganPegouMapa && mapa != null && mapa.activeSelf)
            {
                distanciaMapa = Vector2.Distance(jogador.transform.position, mapa.transform.position);
            }
            else
            {
                distanciaMapa = 999f; // Define uma distância alta para sumir com o balão de interação
            }

            // O botão de sair sempre calcula normal
            if (botaoSair != null)
            {
                distanciaBotao = Vector2.Distance(jogador.transform.position, botaoSair.transform.position);
            }
        }
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
    }

    private void InteracaoEntreCenas()
    {
        // Ajustado para verificar se o botão de sair está atribuído (evita erros se mudar de cena)
        if (botaoSair != null)
        {
            if (distanciaBotao < 2)
            {
                // Aqui na sua lógica original você ativa o próprio botão de sair baseando-se na distância.
                // Se o "botaoSair" for o balão indicador de clique (tipo "Aperte E"), está correto!
                botaoSair.SetActive(true); 
            }
            else
            {
                botaoSair.SetActive(false);
            }
        }
    }
}