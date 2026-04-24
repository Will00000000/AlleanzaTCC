using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton <SceneController>
{
    public bool is_Rua = false, was_Rua = false; //verifica se está ou estava na rua
    public bool is_Museu = false, was_Museu = false; //verifica se está ou estava no museu

    public bool is_Escadaria;

    public Transform player;

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
        SceneManager.LoadScene("Cidade");
    }

    public void GoRua ()
    {
        SceneManager.LoadScene("Rua");
    }

    public void GoMuseu ()
    {
        SceneManager.LoadScene("Museu");

        player.position = new Vector2(17, -2);
    }

    //MINIGAMES

    public void GoQuebraCabeca ()
    {
        SceneManager.LoadScene ("Minigame");
    }

    public void Pocoes ()
    {
        SceneManager.LoadScene ("MinigamePoção");
    }
}