using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerLixos : MonoBehaviour
{
    //MINIGAME DOS LIXOS
    public Transform[] Origem1; //lista de variáveis do tipo Transform para os pontos de origem dos lixosWS
  //  public Transform[] Origem2;
   // public Transform[] Origem3;
  //  public Transform[] Origem4;
 //   public Transform[] Origem5;
//    public Transform[] Origem6;

    public GameObject[] Lixo; //variável para receber o prefab do lixo
 //   public GameObject Lixo2;
  //  public GameObject Lixo3;
  //  public GameObject Lixo4;
 //   public GameObject Lixo5;
//    public GameObject Lixo6;

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

            if (intervaloTempo > 0.50f)
            {
                int pontoAleatorio1 = Random.Range(0, Origem1.Length - 1);
                int lixoleatorio1 = Random.Range(0, Origem1.Length - 1);
                Instantiate(Lixo[lixoleatorio1], Origem1[pontoAleatorio1].position, Origem1[pontoAleatorio1].rotation);

              //  int pontoAleatorio2 = Random.Range(0, Origem2.Length - 1);
            //    Instantiate(Lixo2[], Origem2[pontoAleatorio2].position, Origem1[pontoAleatorio2].rotation);
            }
            
            if (intervaloTempo < tempoMin)
            {
                SceneManager.LoadScene("Atlantis");
            }
        }
    }
}