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

            min_Y = 0.01f;   
            max_Y = 0f;
        }
        else if (nomeCena == "Praia")
        {
            min_X = -26.8f;
            max_X = 14.66f;

            min_Y = -4.0f;  
            max_Y = 5.0f;
        }
        else if (nomeCena == "Escadaria")
        {
            min_X = -4.98f;
            max_X = 5.0f;

            min_Y = 0.03f;  
            max_Y = 0.03f;
        }
    }

    void LateUpdate()
    {
        Vector3 newPosition = alvo.position + new Vector3(0, 0, -10);

        newPosition.x = Mathf.Clamp(newPosition.x, min_X, max_X);
        newPosition.y = Mathf.Clamp(newPosition.y, min_Y, max_Y);

        transform.position = newPosition;
    }
}