using UnityEngine;
using UnityEngine.SceneManagement;

public class Visao : MonoBehaviour
{
    public Transform alvo;

    bool seguir;
    float min_X, max_X;
    private string nomeCena;

    private void FixedUpdate()
    {
        nomeCena = SceneManager.GetActiveScene().name;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, min_X, max_X), transform.position.y, transform.position.z);

        Vector3 newPosition = alvo.position + new Vector3(0, 0, -10);
        transform.position = newPosition;

        if (nomeCena == "MorganHouse")
        {
            min_X = -2.62f;
            max_X = 2.59f;
        }
        else if (nomeCena == "Praia")
        {
            min_X = -26.8f;
            max_X = 14.66f;
        }
    }

    /*void Seguir () //área de ataque a ser implementada
    {
        if (jogador.GetComponent <Jogador2D_Terra> ().CamSeguindo)
        {
            
        }
        else
        {
            transform.position = jogador.GetComponent <Jogador2D_Terra> ().destinoCam;
        }
    }*/
}