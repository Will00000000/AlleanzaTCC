using UnityEngine;
using UnityEngine.SceneManagement;

public class Visao : MonoBehaviour
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
        else if (nomeCena == "Praia")
        {
            min_X = -23.92f;
            max_X = 9.67f;

            min_Y = 2.11f;
            max_Y = 2.11f;
        }
        else if (nomeCena == "Praia2")
        {
            min_X = -12.6f;
            max_X = 0;

            min_Y = 0f;
            max_Y = 0f;
        }
        else if (nomeCena == "Escadaria")
        {
            min_X = -5.01f;
            max_X = 4.99f;

            min_Y = 0f;
            max_Y = 0f;
        }
        else if (nomeCena == "Museu")
        {
            min_X = -9.52f;
            max_X = 9.52f;

            min_Y = 0f;
            max_Y = 0f;
        }
        else if (nomeCena == "Cidade")
        {
            min_X = 45;
            max_X = 187;

            min_Y = 0f;
            max_Y = 0f;
        }
        else if (nomeCena == "MinigameLixos")
        {
            min_X = -3.5f;
            max_X = 0;

            min_Y = -2;
            max_Y = 2;
        }
        else if (nomeCena == "Atlantis")
        {
            min_X = -42;
            max_X = -3;

            min_Y = 0.01f;
            max_Y = 0.01f;
        }
        else if (nomeCena == "CasaHelena")
        {
            min_X = -35;
            max_X = 6;

            min_Y = 0.01f;
            max_Y = 0.01f;
        }
        else if (nomeCena != "CasaHelena")
        {
            min_X = -111111111111;
            max_X = 111111111111;

            min_Y = 0.01f;
            max_Y = 0.01f;
        }
    }

    void Update()
    {
        // Verifica se o alvo (Morgan) existe para não dar erro no console
        if (alvo != null)
        {
            alvoSeguir = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);
            LimiteCam();
        }
    }

    void LimiteCam ()
    {
        GameObject player_obj = GameObject.Find("Jogador");
        
        if (player_obj != null)
        {
            Jogador2D_Terra jogador = player_obj.GetComponent<Jogador2D_Terra>();
        }

        float clampX = Mathf.Clamp(alvoSeguir.x, min_X, max_X);
        float clampY = Mathf.Clamp(alvoSeguir.y, min_Y, max_Y);

        transform.position = new Vector3(clampX, clampY, transform.position.z);
    }
}