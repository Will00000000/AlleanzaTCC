using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    //MINIGAME DOS LIXOS
    public Transform[] pontoOrigem;
    public Transform pontoFinal;

    public GameObject Lixo;
    public GameObject LixoFinal;

    public float timer;
    public float intervaloTempo;

    void Start()
    {
        timer = intervaloTempo;
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

            if (intervaloTempo > 0.20f)
            {
                int pontoAleatorio = Random.Range(0, pontoOrigem.Length - 1);
                Instantiate(Lixo, pontoOrigem[pontoAleatorio].position, pontoOrigem[pontoAleatorio].rotation);

                intervaloTempo -= 0.01f;
            }
            else if (intervaloTempo < 0.21f & intervaloTempo > 0.20f)
            {
                Debug.Log("Lixo final instant");
                Instantiate(LixoFinal, pontoFinal.position, pontoFinal.rotation);
            }
        }
    }
}