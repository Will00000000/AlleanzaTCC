using UnityEngine;
using UnityEngine.SceneManagement;

public class SeguirJogador : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public Transform jogador; 
    public float velocidade = 3f;
    public float distanciaMinima = 1.5f; 

    [Header("Controle")]
    // Mantém o estado de seguir salvo entre a troca de todas as cenas!
    public static bool deveSeguir = false; 

    private static SeguirJogador instancia;

    void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // Não destrói a Mellory ao mudar de cena
        }
        else
        {
            // Se já existe uma Mellory vinda da praia, apaga a duplicada da nova cena
            Destroy(gameObject);
            return;
        }
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += AoCarregarCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= AoCarregarCena;
    }

    void AoCarregarCena(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "MenuPrincipal")
        {
            deveSeguir = false;
            Destroy(gameObject);
            return;
        }

        // Tenta achar o Morgan pelo nome ou pela Tag "Player"
        BuscarJogador();

        if (deveSeguir && jogador != null)
        {
            // Teleporta a Mellory imediatamente para perto do Morgan na nova cena
            transform.position = new Vector3(jogador.position.x - 1f, jogador.position.y, transform.position.z);
        }
    }

    void BuscarJogador()
    {
        // 1. Tenta buscar pelo nome exato "Jogador"
        GameObject playerObj = GameObject.Find("Jogador"); 

        // 2. Se não encontrar pelo nome, busca pela Tag "Player"
        if (playerObj == null)
        {
            playerObj = GameObject.FindGameObjectWithTag("Player");
        }

        if (playerObj != null)
        {
            jogador = playerObj.transform;
        }
        else
        {
            Debug.LogWarning("[Mellory] Não foi possível encontrar o jogador na cena atual!");
        }
    }

    void Update()
    {
        if (!deveSeguir) return;

        // Caso tenha perdido a referência (ex: transição de cena atrasada), busca novamente
        if (jogador == null)
        {
            BuscarJogador();
            return;
        }

        float distancia = Vector2.Distance(transform.position, jogador.position);

        if (distancia > distanciaMinima)
        {
            Vector2 posicaoAlvo = new Vector2(jogador.position.x, jogador.position.y); 
            transform.position = Vector2.MoveTowards(transform.position, posicaoAlvo, velocidade * Time.deltaTime);

            // Vira o sprite da Mellory
            if (jogador.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else if (jogador.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
        }
    }

    public void ComeçarASeguir()
    {
        deveSeguir = true;

        if (jogador == null)
        {
            BuscarJogador();
        }
    }
}