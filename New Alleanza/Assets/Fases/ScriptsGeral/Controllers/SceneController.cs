using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Jogador");
    }

    #region Fase1
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

    public void GoMuseu_from_Cidade ()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);

        SceneManager.LoadScene("Museu");
    }
    #endregion

    public void GoMuseu_from_QuebraCabeca()
    {
        PlayerPrefs.SetInt("was_QuebraCabeça", 1);
        PlayerPrefs.SetInt("Visitou quebra-cabeça", 1);

        SceneManager.LoadScene("Museu");
    }

    public void GoCastelo_from_Atlantis ()
    {
        PlayerPrefs.SetInt ("was_Atlantis", 1);
        PlayerPrefs.SetInt ("Visitou o quarto de Selene", 1);

        SceneManager.LoadScene ("Castelo");
    }

    public void GoCastelo_from_QuartoSelene ()
    {
        PlayerPrefs.SetInt("was_QuartoSelene", 1);

        SceneManager.LoadScene("Castelo");
    }

    public void GoQuartoSelene_from_Castelo ()
    {
        PlayerPrefs.SetInt("was_QuartoSelene", 1);

        SceneManager.LoadScene("QuartoSelene");
    }

    public void GoAtlantis_from_Castelo ()
    {
        PlayerPrefs.SetInt ("was_Castelo", 1);

        SceneManager.LoadScene ("Atlantis");
    }

    public void GoPraia_from_Atlantis ()
    {
        PlayerPrefs.SetInt ("was_Atlantis", 1);

        SceneManager.LoadScene ("Praia");
    }

    public void GoCasaHelena_from_Cidade ()
    {
        PlayerPrefs.SetInt ("was_Cidade", 1);

        SceneManager.LoadScene ("CasaHelena");
    }

    public void GoCidade_from_CasaHelena ()
    {
        PlayerPrefs.SetInt("was_CasaHelena", 1);

        SceneManager.LoadScene("Cidade");
    }

    public void GoMinigameCaixa_from_CasaHelena ()
    {
        SceneManager.LoadScene ("MinigameCaixa");
    }

    public void GoCasaHelena_from_MinigameCaixa ()
    {
        PlayerPrefs.SetInt("Visitou o minigame das caixas", 1);
        PlayerPrefs.SetInt("was_MinigameCaixa", 1);

        SceneManager.LoadScene ("CasaHelena");
    }

    public void GoRefugio_from_Praia ()
    {
        SceneManager.LoadScene ("Refúgio"); //Não precisa de verificação de entrada porque o jogador não volta do refúgio
    }

    public void GoPraia_from_Refugio ()
    {
        PlayerPrefs.SetInt ("was_Refúgio", 1);

        SceneManager.LoadScene ("Praia");
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