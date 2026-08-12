using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerLixos : MonoBehaviour
{
    //MINIGAME DOS LIXOS
    public Transform[] pontoOrigem; //lista de variáveis do tipo Transform para os pontos de origem dos lixos

    public GameObject Lixo; //variável para receber o prefab do lixo

    public float timer; //temporizador para cada surgimento
    public float intervaloTempo; //intervalo entre os surgimentos que vai ficando cada vez menor
    public float tempoMin; //tempo mínimo que o jogo tem para acabar

    void Start()
    {
        timer = intervaloTempo; //
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "MinigameLixos")
        {
            criaAsteroides();
        }
    }

    void criaAsteroides()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = intervaloTempo;
            intervaloTempo -= 0.01f;

            if (intervaloTempo > 0.20f)
            {
                int pontoAleatorio = Random.Range(0, pontoOrigem.Length - 1);
                Instantiate(Lixo, pontoOrigem[pontoAleatorio].position, pontoOrigem[pontoAleatorio].rotation);
            }
            
            if (intervaloTempo < tempoMin)
            {
                SceneManager.LoadScene("Atlantis");
            }
        }
    }
}