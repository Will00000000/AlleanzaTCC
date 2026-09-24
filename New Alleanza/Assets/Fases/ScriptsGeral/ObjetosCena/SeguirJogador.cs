using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class SeguirJogador : MonoBehaviour
{
    // Dicionário estático para guardar UMA instância de cada personagem pelo ID
    private static Dictionary<string, SeguirJogador> instancias = new Dictionary<string, SeguirJogador>();

    [Header("Identificação do Personagem")]
    [Tooltip("Dê um ID único para cada NPC (ex: 'Melory', 'Melissa')")]
    public string idPersonagem = "NPC_Unico";

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
        // Limpa referências nulas que possam ter sobrado de cenas anteriores
        LimparInstanciasNulas();

        // Se já existe um personagem com este MESMO ID no dicionário...
        if (instancias.ContainsKey(idPersonagem) && instancias[idPersonagem] != this)
        {
            // É uma duplicata real do MESMO personagem! Destrói esta nova cópia.
            Destroy(gameObject);
            return;
        }

        // Se é o primeiro dessa ID, registra e mantém entre cenas
        instancias[idPersonagem] = this;
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
            
            // Remove do dicionário antes de destruir
            if (instancias.ContainsKey(idPersonagem) && instancias[idPersonagem] == this)
            {
                instancias.Remove(idPersonagem);
            }

            Destroy(gameObject);
            return;
        }

        // Aguarda 1 frame para garantir que o Morgan já foi reposicionado pelo SpawnPoint da cena
        StartCoroutine(PosicionarJuntoAoJogador());
    }

    IEnumerator PosicionarJuntoAoJogador()
    {
        // Espera o final do frame atual e a inicialização de todos os scripts
        yield return new WaitForEndOfFrame();

        BuscarJogador();

        if (deveSeguir && jogador != null)
        {
            transform.position = new Vector3(jogador.position.x + offsetTeleport.x, jogador.position.y + offsetTeleport.y, transform.position.z);
        }
    }

    void LimparInstanciasNulas()
    {
        List<string> chavesParaRemover = new List<string>();
        foreach (var item in instancias)
        {
            if (item.Value == null)
            {
                chavesParaRemover.Add(item.Key);
            }
        }
        foreach (var chave in chavesParaRemover)
        {
            instancias.Remove(chave);
        }
    }

    void BuscarJogador()
    {
        GameObject playerObj = GameObject.Find("Morgan");

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

        // Se estiver além da distância mínima, move o NPC e ativa a animação contínua
        if (distancia > distanciaMinima)
        {
            Vector2 posicaoAlvo = new Vector2(jogador.position.x, jogador.position.y);
            transform.position = Vector2.MoveTowards(transform.position, posicaoAlvo, velocidade * Time.deltaTime);

            if (jogador.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(-Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }
            else if (jogador.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
            }

            AtualizarAnimacao(true);
        }
        else
        {
            // Chegou ao destino / distância mínima: para a animação na hora
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