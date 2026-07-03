using UnityEngine;
using UnityEngine.SceneManagement;

public class TransformEntreCenas: MonoBehaviour
{
    private void Start () //no primeiro frame e depois do Awake()
    {
        if (SceneManager.GetActiveScene().name == "MorganHouse")
        {
            IsQuartoMorgan();
        }

        if (SceneManager.GetActiveScene().name == "Praia")
        {
            IsPraia();
        }

        if (SceneManager.GetActiveScene().name == "Praia2")
        {
            IsPraia2();
        }

        if (SceneManager.GetActiveScene().name == "Escadaria")
        {
            IsEscadaria();
        }
        if (SceneManager.GetActiveScene().name == "Cidade")
        {
            IsCidade();
        }
        if (SceneManager.GetActiveScene().name == "Museu")
        {
            IsMuseu();
        }
    }
    private void IsQuartoMorgan()
    {
        if (PlayerPrefs.GetInt("was_Praia", 0) == 1) // se estava na praia...
        {
            Debug.Log("Jogador está no quarto e estava na praia");
            transform.position = new Vector2(-3, transform.position.y); // posição no quarto vai para a porta
        }
    }

    private void IsPraia ()
    {
        if (PlayerPrefs.GetInt ("was_QuartoMorgan", 0) == 1)
        {
            Debug.Log("Jogador está na praia e estava no quarto");
            transform.position = new Vector2(-20, transform.position.y);
        }

        if (PlayerPrefs.GetInt("was_Praia2", 0) == 1)
        {
            Debug.Log("Jogador está na praia e estava na praia2");
            transform.position = new Vector2(-30f, transform.position.y);
        }
    }

    private void IsPraia2 ()
    {
        if (PlayerPrefs.GetInt ("was_Praia", 0) == 1)
        {
            transform.position = new Vector2(6, transform.position.y);
        }

        if (PlayerPrefs.GetInt ("was_Escadaria", 0) == 1)
        {
            transform.position = new Vector2(-12, transform.position.y);
        }
    }

    private void IsEscadaria()
    {
        if (PlayerPrefs.GetInt("was_Praia2", 0) == 1)
        {
            transform.position = new Vector2(9, transform.position.y);
        }

        if (PlayerPrefs.GetInt("was_Cidade", 0) == 1)
        {
            transform.position = new Vector2(-2, transform.position.y);
        }
    }

    private void IsCidade()
    {
        if (PlayerPrefs.GetInt("was_Escadaria", 0) == 1)
        {
            transform.position = new Vector2(195, transform.position.y);
        }

        if (PlayerPrefs.GetInt("was_Museu", 0) == 1)
        {
            transform.position = new Vector2(65, transform.position.y);
        }
    }

    private void IsMuseu()
    {
        if (PlayerPrefs.GetInt("was_Cidade", 0) == 1)
        {
            transform.position = new Vector2(17, transform.position.y);
        }

        if (PlayerPrefs.GetInt("was_QuebraCabeça", 0) == 1)
        {
            transform.position = new Vector2(-6, transform.position.y);
        }
    }

    private void IsAtlantis()
    {

    }
}