using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void GoPraia()
    {
        SceneManager.LoadScene("Praia");
    }

    public void GoCasa()
    {
        SceneManager.LoadScene("MorganHouse");
    }

    public void GoEscadaria()
    {
        SceneManager.LoadScene("Escadaria");
    }
    
    public void GoCidade ()
    {
        SceneManager.LoadScene ("Cidade");
    }

    public void GoQuebraCabeca ()
    {
        SceneManager.LoadScene ("Minigame");
    }

    public void Pocoes ()
    {
        SceneManager.LoadScene ("MinigamePoção");
    }
}