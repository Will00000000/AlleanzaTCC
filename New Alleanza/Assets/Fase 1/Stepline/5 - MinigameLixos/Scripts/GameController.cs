using UnityEngine;

public class GameController : MonoBehaviour
{
    public Transform [] pontoOrigem;
    public GameObject Lixo;

    public float timer;
    public float intervaloTempo;

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
}