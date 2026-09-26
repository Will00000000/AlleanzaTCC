using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoCasa_from_Praia()
    {
        PlayerPrefs.SetInt("was_Praia", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("MorganHouse");
    }

    public void GoPraia_from_Casa()
    {
        // Força a atualização do PlayerPrefs para ler os valores mais recentes
        int mochila = PlayerPrefs.GetInt("tem_Mochila", 0);
        int mapa = PlayerPrefs.GetInt("tem_Mapa", 0);
        int jaPeguei = PlayerPrefs.GetInt("Ja_Peguei", 0);

        bool temMochila = mochila == 1;
        bool temMapa = mapa == 1;

        if ((temMochila && temMapa) || jaPeguei == 1)
        {
            PlayerPrefs.SetInt("was_QuartoMorgan", 1);
            PlayerPrefs.SetInt("tem_Mochila", 0);  
            PlayerPrefs.SetInt("tem_Mapa", 0); 
            PlayerPrefs.SetInt("Ja_Peguei", 1);  
            PlayerPrefs.Save();

            SceneManager.LoadScene("Praia");
        }
        else
        {
            Debug.Log("Você precisa pegar a Mochila e o Mapa antes de sair para a Praia!");
            Debug.Log($"Mochila: {mochila} | Mapa: {mapa}");
            PlayerPrefs.SetInt("Ja_Peguei", 0); 
            PlayerPrefs.Save();
        }
        
        Debug.Log("Mochila " + PlayerPrefs.GetInt("tem_Mochila") + " Mapa " + PlayerPrefs.GetInt("tem_Mapa") + " peguei tudo " + PlayerPrefs.GetInt("Ja_Peguei"));
    }

    public void GoPraia_from_Praia2()
    {
        PlayerPrefs.SetInt("was_Praia2", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Praia");
    }

    public void GoPraia2_from_Praia()
    {
        PlayerPrefs.SetInt("was_Praia", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Praia2");
    }
    
    public void GoPraia2_from_Escadaria()
    {
        PlayerPrefs.SetInt("was_Escadaria", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Praia2");
    }

    public void GoEscadaria_from_Praia2()
    {
        PlayerPrefs.SetInt("was_Praia2", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Escadaria");
    }

    public void GoEscadaria_from_Cidade()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Escadaria");
    }

    public void GoCidade_from_Escadaria()
    {
        PlayerPrefs.SetInt("was_Escadaria", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Cidade");
    }

    public void GoCidade_from_Museu()
    {
        PlayerPrefs.SetInt("was_Museu", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Cidade");
    }

    public void GoMuseu_from_Cidade()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Museu");
    }

    public void GoMuseu_from_QuebraCabeca()
    {
        PlayerPrefs.SetInt("was_QuebraCabeça", 1);
        PlayerPrefs.SetInt("Visitou quebra-cabeça", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Museu");
    }

    public void GoCastelo_from_Atlantis()
    {
        PlayerPrefs.SetInt("was_Atlantis", 1);
        PlayerPrefs.SetInt("Visitou o castelo", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Castelo");
    }

    public void GoCastelo_from_QuartoSelene()
    {
        PlayerPrefs.SetInt("was_QuartoSelene", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Castelo");
    }

    public void GoQuartoSelene_from_Castelo()
    {
        PlayerPrefs.SetInt("was_QuartoSelene", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("QuartoSelene");
    }

    public void GoAtlantis_from_Castelo()
    {
        PlayerPrefs.SetInt("was_Castelo", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Atlantis");
    }

    public void GoPraia_from_Atlantis()
    {
        PlayerPrefs.SetInt("was_Atlantis", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Praia");
    }

    public void GoCasaHelena_from_Cidade()
    {
        PlayerPrefs.SetInt("was_Cidade", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("CasaHelena");
    }

    public void GoCidade_from_CasaHelena()
    {
        PlayerPrefs.SetInt("was_CasaHelena", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Cidade");
    }

    public void GoMinigameCaixa_from_CasaHelena()
    {
        SceneManager.LoadScene("MinigameCaixa");
    }

    public void GoCasaHelena_from_MinigameCaixa()
    {
        PlayerPrefs.SetInt("Visitou o minigame das caixas", 1);
        PlayerPrefs.SetInt("was_MinigameCaixa", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("CasaHelena");
    }

    public void GoRefugio_from_Praia()
    {
        SceneManager.LoadScene("Refúgio");
    }

    public void GoPraia_from_Refugio()
    {
        PlayerPrefs.SetInt("was_Refúgio", 1);
        PlayerPrefs.Save();

        SceneManager.LoadScene("Praia");
    }

    public void GoQuebraCabeca()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void GoPocoes()
    {
        SceneManager.LoadScene("MinigamePoção");
    }

    public void GoLixos()
    {
        SceneManager.LoadScene("MinigameLixos");
    }

    public void GoOceano()
    {
        SceneManager.LoadScene("Atlantis");
    }

    public void GoMenuPrincipal ()
    {
        SceneManager.LoadScene ("MenuPrincipal");
    }
}