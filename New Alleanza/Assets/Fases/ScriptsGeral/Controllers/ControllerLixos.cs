using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerLixos : MonoBehaviour
{
    //MINIGAME DOS LIXOS
    public Transform[] Origem; //lista de variáveis do tipo Transform para os pontos de origem dos lixosWS

    public GameObject[] Lixo; //variável para receber o prefab do lixo

    public float timer; //temporizador para cada surgimento
    public float intervaloTempo; //intervalo entre os surgimentos que vai ficando cada vez menor
    public float tempoMin; //tempo mínimo que o jogo tem para acabar

    public static float pontuação;

    void Start()
    {
        timer = intervaloTempo;

        pontuação = 0;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MinigameLixos")
        {
            criaLixos();
        }
    }

    void criaLixos()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = intervaloTempo;
            intervaloTempo -= 0.01f;

            if (intervaloTempo > 0.50f)
            {
                int pontoAleatorio = Random.Range(0, Origem.Length - 1);
                int lixoleatorio = Random.Range(0, Lixo.Length - 1);
                Instantiate(Lixo[lixoleatorio], Origem[pontoAleatorio].position, Origem[pontoAleatorio].rotation);
            }
            
            if (intervaloTempo < tempoMin)
            {
                SceneManager.LoadScene("Atlantis");
            }
        }
    }
}