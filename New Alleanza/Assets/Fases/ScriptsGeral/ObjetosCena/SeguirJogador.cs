using UnityEngine;
using UnityEngine.SceneManagement;

public class SeguirJogador : MonoBehaviour
{
    [Header("Configurações de Movimento")]
    public Transform jogador; 
    public float velocidade = 3f;
    public float distanciaMinima = 1.5f; 
    public Vector2 offsetTeleport = new Vector2(-1f, 0f);

    [Header("Controle")]
    public bool deveSeguir = false; 

    [Header("Animação")]
    public Animator animator;
    public string parametroAndando = "estaAndando"; 

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (animator == null)
        {
            animator = GetComponent<Animator>();
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

        BuscarJogador();

        if (deveSeguir && jogador != null)
        {
            transform.position = new Vector3(jogador.position.x + offsetTeleport.x, jogador.position.y + offsetTeleport.y, transform.position.z);
        }
    }

    void BuscarJogador()
    {
        GameObject playerObj = GameObject.Find("Jogador"); 

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
            Debug.LogWarning($"[{gameObject.name}] Não foi possível encontrar o jogador na cena atual!");
        }
    }

    void Update()
    {
        if (!deveSeguir) 
        {
            AtualizarAnimacao(false);
            return;
        }

        if (jogador == null)
        {
            BuscarJogador();
            AtualizarAnimacao(false);
            return;
        }

        float distancia = Vector2.Distance(transform.position, jogador.position);

        if (distancia > distanciaMinima)
        {
            Vector2 posicaoAlvo = new Vector2(jogador.position.x, jogador.position.y); 
            transform.position = Vector2.MoveTowards(transform.position, posicaoAlvo, velocidade * Time.deltaTime);

            // CORREÇÃO: Sinais invertidos para ajustar à orientação original dos sprites da Melissa
            if (jogador.position.x > transform.position.x)
            {
                // Morgan à DIREITA: aplica sinal negativo para a Melissa olhar para a direita
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else if (jogador.position.x < transform.position.x)
            {
                // Morgan à ESQUERDA: aplica sinal positivo para a Melissa olhar para a esquerda
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }

            AtualizarAnimacao(true);
        }
        else
        {
            AtualizarAnimacao(false);
        }
    }

    void AtualizarAnimacao(bool estaAndando)
    {
        if (animator != null)
        {
            animator.SetBool(parametroAndando, estaAndando);
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