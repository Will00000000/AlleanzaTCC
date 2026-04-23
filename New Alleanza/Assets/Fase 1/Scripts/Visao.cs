using UnityEngine;
using UnityEngine.SceneManagement;

public class Visao : Singleton <Visao>
{
    public Transform alvo;
    Vector3 alvoSeguir;

    float min_X, max_X;
    float min_Y, max_Y;

    void Start()
    {
        string nomeCena = SceneManager.GetActiveScene().name;

        if (nomeCena == "MorganHouse")
        {
            min_X = -2.62f;
            max_X = 2.59f;

            min_Y = -0.13f;
            max_Y = 3.0f;
        }

        if (nomeCena == "Praia")
        {
            min_X = -26.8f;
            max_X = 14.66f;

            min_Y = -4.0f; // ajuste conforme seu cenário
            max_Y = 5.0f;
        }

        if (nomeCena == "Escadaria")
        {
            min_X = -5.01f;
            max_X = 4.99f;

            min_Y = 0f;
            max_Y = 0f;
        }

        if (nomeCena == "Rua")
        {
            min_X = -80;
            max_X = 80;
        }

        if (nomeCena == "Museu")
        {
            min_X = 9.5f;
            max_X = -9.5f;
        }
    }

    void Update()
    {
        alvoSeguir = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);

        LimiteCam ();
    }

    void LimiteCam ()
    {
        float clampX = Mathf.Clamp (alvoSeguir.x, min_X, max_X); //limite de câmera no eixo x
        float clampY = Mathf.Clamp (alvoSeguir.y, min_Y, max_Y); //limite de câmera no eixo y

        transform.position = new Vector3 (clampX, clampY, transform.position.z); //câmera se move com o limite aplicado
    }
}