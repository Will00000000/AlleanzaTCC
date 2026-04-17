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
        alvoSeguir = new Vector3(alvo.position.x, alvo.position.y, transform.position.z);

        LimiteCam();
    }

    void LimiteCam ()
    {
        GameObject player_obj = GameObject.Find("Jogador"); //como a câmera está distante do jogador, precisa procurar o objeto dele antes  de qualquer coisa
        Jogador2D_Terra jogador = player_obj.GetComponent<Jogador2D_Terra>(); //pega o script do jogador, porque está no mesmo objeto.
        
        if (jogador.Is_Rua1 == true) // corrigido
        {
            min_X = 110.5f; //limite das câmeras 
            max_X = 129.37f;

            min_Y = 3.32f;
        }

        float clampX = Mathf.Clamp(alvoSeguir.x, min_X, max_X);//limite de câmera no eixo x
        float clampY = Mathf.Clamp(alvoSeguir.y, min_Y, max_Y);//limite de câmera no eixo y

        transform.position = new Vector3(clampX, clampY, transform.position.z);//câmera se move com o limite aplicando
    }
}