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

        Debug.Log(PlayerPrefs.GetInt("was_QuartoMorgan"));
    }
    private void IsQuartoMorgan() // verificação de origem no quarto
    {
        if (PlayerPrefs.GetInt("was_Praia", 0) == 1) // se estava na praia...
        {
            transform.position = new Vector2(-3, transform.position.y); //... x = -3

            PlayerPrefs.SetInt("was_Praia", 0);
        }

        PlayerPrefs.SetInt("was_QuartoMorgan", 0); // como ele está no quarto no presente, não tem como considerar que ele estava no passado
    }

    private void IsPraia () //verificação de origem na praia
    {
        if (PlayerPrefs.GetInt ("was_QuartoMorgan", 0) == 1) //se o jogador estava no quarto
        {
            transform.position = new Vector2(-20, transform.position.y); //x = -20

            PlayerPrefs.SetInt("was_QuartoMorgan", 0); //e como o jogador já foi deslocado, não precisamos saber que estava no quarto
        }

        if (PlayerPrefs.GetInt("was_Praia2", 0) == 1) //se o jogador estava no quarto...
        {
            transform.position = new Vector2(-30, transform.position.y); //...x = -30

            PlayerPrefs.SetInt("was_Praia2", 0); //e como o jogador já foi deslocado, não precisamos saber que estava na praia 2
        }

        PlayerPrefs.SetInt("was_Praia", 0); //como ele está na praia no presente, não tem como considerar que ele estava no passado
    }

    private void IsPraia2 ()
    {
        if (PlayerPrefs.GetInt ("was_Praia", 0) == 1)
        {
            transform.position = new Vector2(6, transform.position.y);

            PlayerPrefs.SetInt("was_Praia", 0);
        }

        if (PlayerPrefs.GetInt ("was_Escadaria", 0) == 1)
        {
            transform.position = new Vector2(-12, transform.position.y);

            PlayerPrefs.SetInt("was_Escadaria", 0);
        }

        PlayerPrefs.SetInt("was_Praia2", 0);
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