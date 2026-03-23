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
    }

    void Update()
    {
        alvoSeguir = new Vector3 (alvo.position.x, alvo.position.y, transform.position.z);

        LimiteCam ();
    }

    void LimiteCam ()
    {
        GameController controlador = GetComponent <GameController> (); //pega o script do jogador, porque está no mesmo objeto

        if (controlador.Is_Rua1 = true) //verifica se Rua1 é verdadeiro (se está na primeira rua)
        {
            min_X = 200; //limites das câmeras
            max_X = 129.37f;

            min_Y = 3.32f;

            //Debug.Log ("rua1");
        }

        if (controlador.Is_Rua2 = true) //verifica se Rua2 é verdadeiro (se está na segunda rua)
        {
            min_X = 71.61f; //limite x
            max_X = 90.49f;

            min_Y = 3.32f; //limite y

            Debug.Log ("Rua2");
        }

        float clampX = Mathf.Clamp (alvoSeguir.x, min_X, max_X); //limite de câmera no eixo x
        float clampY = Mathf.Clamp (alvoSeguir.y, min_Y, max_Y); //limite de câmera no eixo y

        transform.position = new Vector3 (clampX, clampY, transform.position.z); //câmera se move com o limite aplicado
    }
}