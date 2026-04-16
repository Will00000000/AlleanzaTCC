using UnityEngine;
using UnityEngine.SceneManagement;

public class Transform_Player : Singleton <Transform_Player>
{   
    void Start ()
    {
        if (SceneController.Instance.is_Rua1 == false && SceneController.Instance.is_Rua2 == true) //... e se o jogador saiu da rua 1...
        {
            transform.position = new Vector2 (16.5f,-3.42f); //jogador vai para essa posição
            Debug.Log ("Não está na rua 1");
        }
    }

    void Update ()
    {
        //Rua1 ();
    }

    void Rua1 () //função que usa a rua 1 como referência
    {
        if (SceneManager.GetActiveScene().name == "Rua1") //se a cena atual for rua 1...
        {
            

            Debug.Log ("Está na rua 1");
        }
    }

    /*public void GoRua_2_1 () //da rua 2 para a rua 1
    {
        SceneManager.LoadScene ("Rua1"); //carrega rua 1
        jogador.position = new Vector2 (16.4f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
    }

    public void GoRua_2_3 () //da rua 2 para a rua 3
    {
        SceneManager.LoadScene ("Rua3"); //carrega rua 3
        jogador.position = new Vector2 (16.6f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
    }

    public void GoRua_3_2 () //da rua 3 para a rua 2
    {
        SceneManager.LoadScene ("Rua2"); //carrega rua 3
        jogador.position = new Vector2 (16.6f,-3.4f); //quando a cena for carregada, o jogador inicia aqui
    }*/

}