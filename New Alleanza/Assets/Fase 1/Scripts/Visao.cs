using UnityEngine;
using UnityEngine.SceneManagement;

public class Visao : MonoBehaviour
{
    public Transform alvo;

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

        else if (nomeCena == "Praia")
        {
            min_X = -26.8f;
            max_X = 14.66f;

            min_Y = -4.0f; // ajuste conforme seu cenário
            max_Y = 5.0f;
        }

        else if (nomeCena == "Escadaria")
        {
            min_X = -5.01f;
            max_X = 4.99f;

            min_Y = 0f;
            max_Y = 0f;
        }

        if (nomeCena == "Cidade")
        {
            min_X = -10.85f;
            max_X = 10.88f;

            min_Y = 3.24f;
        }
    }

    void Update()
    {
        Vector3 alvoSeguir = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);

        // aplicar limites
        float clampX = Mathf.Clamp (alvoSeguir.x, min_X, max_X);
        float clampY = Mathf.Clamp (alvoSeguir.y, min_Y, max_Y);

        transform.position = new Vector3 (clampX, clampY, transform.position.z);
    }
}