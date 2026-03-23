using UnityEngine;

public class GameController : MonoBehaviour
{
    //MINIGAME DOS LIXOS
    public Transform [] pontoOrigem;
    public GameObject Lixo;

    public float timer;
    public float intervaloTempo;

    //RUAS DA CIDADE
    public GameObject jogador;
    public bool Is_Rua1 = false, Is_Rua2 = false, Is_Rua3 = false;

    void Start ()
    {
        timer = intervaloTempo;
    }

    void Update ()
    {
        criaAsteroides ();
    }

    void criaAsteroides ()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = intervaloTempo;

            if (intervaloTempo > 0.20f)
            {
                int pontoAleatorio = Random.Range (0, pontoOrigem.Length -1);
                Instantiate (Lixo, pontoOrigem [pontoAleatorio].position, pontoOrigem [pontoAleatorio].rotation);

                intervaloTempo -= 0.01f;
            }
        }
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "detectorRua1") //detecta se o jogador está na rua 1 (referenciado em "Visao")
        {
            Is_Rua1 = true;
        }

        if (col.gameObject.tag == "detectorRua2")
        {
            Is_Rua2 = true;
        }
        
        if (col.gameObject.tag == "detectorRua3")
        {
            Is_Rua3 = true;
        }
    }
}