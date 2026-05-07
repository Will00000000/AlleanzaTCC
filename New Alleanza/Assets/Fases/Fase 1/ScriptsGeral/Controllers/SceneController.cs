using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject player;

    private void Start()
    {
        player = GameObject.Find("Jogador");
    }

    #region Cenários principais
    public void GoCasa ()
    {
        SceneManager.LoadScene("MorganHouse");
    }

    public void GoPraia ()
    {
        SceneManager.LoadScene("Praia");
    }

    public void GoEscadaria ()
    {
        SceneManager.LoadScene("Escadaria");
    }

    public void GoCidade ()
    {
        SceneManager.LoadScene("Cidade");
    }
    public void GoMuseu ()
    {
        SceneManager.LoadScene("Museu");
    }
    #endregion

    #region Minigames
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
    #endregion
}