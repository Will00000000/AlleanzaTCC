using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public Transform jogador;
    bool is_Rua1, is_Rua2, is_Rua3; //verifica em qual rua está atualmente
    bool was_Rua1, was_Rua2, was_Rua3; //verifica em qual rua estava na cena passada

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

    public void GoRua1 ()
    {
        SceneManager.LoadScene ("Rua1"); //carrega rua 1
        jogador.position = new Vector2 (16.4f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
    }

    public void GoRua2 ()
    {
        SceneManager.LoadScene ("Rua2"); //carrega rua 2
        jogador.position = new Vector2 (16.4f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
    }

    public void GoRua3 ()
    {
        SceneManager.LoadScene ("Rua3"); //carrega rua 3
        jogador.position = new Vector2 (16.6f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
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