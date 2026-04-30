using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton<SceneController>
{
    public GameObject player;

    public bool is_Escadaria, was_Escadaria;
    public bool is_Rua, was_Rua;
    public bool is_QuartoMorgan, was_QuartoMorgan;
    public bool is_Praia, was_Praia;
    public bool is_Museu, was_Museu;

    private void OnEnable()
    {
        //SceneManager.sceneLoaded += QuandoCenaCarregar;
    }

    private void OnDisable()
    {
        //SceneManager.sceneLoaded -= QuandoCenaCarregar;
    }

    private void Start()
    {
        player = GameObject.Find("Jogador");
    }

    public void GoCasa_from_Praia ()
    {
        SceneManager.LoadScene("MorganHouse");

        is_QuartoMorgan = true;
        was_Praia = true;
    }

    public void GoPraia_from_Casa ()
    {
        SceneManager.LoadScene("Praia");

        is_Praia = true;
        was_QuartoMorgan = true;
    }

    public void GoPraia_from_Escadaria ()
    {
        SceneManager.LoadScene("Praia");

        is_Praia = true;
        was_Escadaria = true;
    }

    public void GoEscadaria_from_Praia()
    {
        SceneManager.LoadScene("Escadaria");

        is_Escadaria = true;
        was_Praia = true;
    }

    public void GoEscadaria_from_Cidade ()
    {
        SceneManager.LoadScene("Escadaria");

        is_Escadaria = true;
        was_Rua = true;
    }

    public void GoCidade_from_Escadaria ()
    {
        SceneManager.LoadScene("Cidade");

        is_Rua = true;
        was_Escadaria = true;
    }

    public void GoCidade_from_Museu ()
    {
        SceneManager.LoadScene("Cidade");

        is_Rua = true;
        was_Museu = true;
    }

    public void GoMuseu_from_Cidade()
    {
        SceneManager.LoadScene("Museu");

        is_Museu = true;
        was_Rua = true;
    }

    public void GoQuebraCabeca()
    {
        SceneManager.LoadScene("Minigame");
    }

    public void GoPocoes()
    {
        SceneManager.LoadScene("MinigamePoção");
    }
}