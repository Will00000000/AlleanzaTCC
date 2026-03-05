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

            min_Y = 0.1f;   
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

        /*else if (nomeCena == "Cidade")
        {
            min_X = 3.38;
            max_X = 4.99f;

            transform.position = new Vector2 (transform.position.x, 3.31f);
        }*/
    }

    void Update()
    {
        Vector3 newPosition = alvo.position + new Vector3 (0, 3.31f, -10);
        newPosition.x = Mathf.Clamp(newPosition.x, min_X, max_X);
        
        transform.position = alvo.transform.position + newPosition;
    }
}