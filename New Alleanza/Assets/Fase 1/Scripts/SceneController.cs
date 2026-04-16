using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : Singleton <SceneController>
{
    public bool is_Rua; //verifica se está na rua
    public bool is_Escadaria;

    public bool was_Rua; //verifica se estava na rua

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

    //RUAS

    public void GoRua ()
    {
        
    }

    public void GoRua2 ()
    {
        
    }

    public void GoRua3 ()
    {
        
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