using UnityEngine;
using UnityEngine.SceneManagement; // Necessário para detectar mudança de cena

public class SeguirJogador : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public Transform jogador; 
    public float velocidade = 3f;
    public float distanciaMinima = 1.5f; 

    [Header("Controle")]
    public bool deveSeguir = false;

    private static SeguirJogador instancia;
    void Awake()
    {
        // Se ainda não existir uma instância, esta será a principal
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject); // Garante que ela não morra entre as cenas
        }
        else
        {
            // Se já existir uma Mellory vinda de outra cena, destrói essa nova que tentou nascer
            Destroy(gameObject);
        }
    }

    void OnEnable()
    {
        // Avisa ao Unity para rodar uma função sempre que uma cena carregar
        SceneManager.sceneLoaded += AoCarregarCena;
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= AoCarregarCena;
    }

    // Função que roda automaticamente toda vez que muda de fase
    void AoCarregarCena(Scene scene, LoadSceneMode mode)
    {
        // Se mudou para o Menu Principal, destrói a Mellory para ela não ir pro menu
        if (scene.name == "MenuPrincipal")
        {
            Destroy(gameObject);
            return;
        }

        // Procura o "Novo" Morgan que nasceu na nova cena
        GameObject playerObj = GameObject.Find("Jogador"); // Coloque o nome EXATO do objeto do seu jogador aqui
        if (playerObj != null)
        {
            jogador = playerObj.transform;

            // --- ADAPTADO: TELEPORTE IMEDIATO AO MUDAR DE CENA ---
            if (deveSeguir)
            {
                // Coloca a Mellory um pouco para a esquerda (-1f) do Morgan instantaneamente
                transform.position = new Vector3(jogador.position.x - 1f, jogador.position.y, transform.position.z);
            }
        }
    }

    void Update()
    {
        if (!deveSeguir || jogador == null) return;

        float distancia = Vector2.Distance(transform.position, jogador.position);

        if (distancia > distanciaMinima)
        {
            // Ajustado para seguir nos dois eixos
            Vector2 posicaoAlvo = new Vector2(jogador.position.x, jogador.position.y); 

            transform.position = Vector2.MoveTowards(transform.position, posicaoAlvo, velocidade * Time.deltaTime);

            // Vira o sprite da Mellory
            if (jogador.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
        }
    }

    public void ComeçarASeguir()
    {
        deveSeguir = true;
    }
}