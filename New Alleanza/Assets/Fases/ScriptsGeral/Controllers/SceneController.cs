using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Jogador");
    }

    public void GoCasa_from_Praia()
    {
        PlayerPrefs.SetInt("was_Praia", 1);

        SceneManager.LoadScene("MorganHouse");
    }

    public void GoPraia_from_Casa()
    {
        PlayerPrefs.SetInt("was_QuartoMorgan", 1);

        SceneManager.LoadScene("Praia");
    }

    public void GoPraia_from_Praia2()
    {
        PlayerPrefs.SetInt("was_Praia2", 1);

        SceneManager.LoadScene("Praia");
    }

    public void GoPraia2_from_Praia()
    {
        PlayerPrefs.SetInt ("was_Praia", 1);

        SceneManager.LoadScene("Praia2");
    }

    public void GoPraia2_from_Escadaria()
    {
        PlayerPrefs.SetInt ("was_Escadaria", 1);

        SceneManager.LoadScene("Praia2");
    }

    public void GoEscadaria_from_Praia2()
    {
        PlayerPrefs.SetInt("was_Praia2", 1);

        SceneManager.LoadScene("Escadaria");
    }

    public void GoEscadaria_from_Cidade()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);

        SceneManager.LoadScene("Escadaria");
    }

    public void GoCidade_from_Escadaria ()
    {
        PlayerPrefs.SetInt("was_Escadaria", 1);

        SceneManager.LoadScene("Cidade");
    }

    public void GoCidade_from_Museu ()
    {
        PlayerPrefs.SetInt("was_Museu", 1);

        SceneManager.LoadScene("Cidade");
    }

    public void GoCidade_from_CasaHelena ()
    {
        PlayerPrefs.SetInt("was_CasaHelena", 1);

        SceneManager.LoadScene("Cidade");
    }

    public void GoMuseu_from_Cidade ()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);

        SceneManager.LoadScene("Museu");
    }

    public void GoCasaHelena_from_Cidade()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);

        SceneManager.LoadScene("CasaHelena");
    }

    public void GoMuseu_from_QuebraCabeca()
    {
        PlayerPrefs.SetInt("was_QuebraCabeça", 1);
        PlayerPrefs.SetInt("Visitou quebra-cabeça", 1);

        SceneManager.LoadScene("Museu");
    }

    public void GoQuebraCabeca()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void GoPocoes()
    {
        SceneManager.LoadScene("MinigamePoção");
    }

    public void GoLixos ()
    {
        SceneManager.LoadScene("MinigameLixos");
    }

    public void GoOceano ()
    {
        SceneManager.LoadScene("Atlantis");
    }
}