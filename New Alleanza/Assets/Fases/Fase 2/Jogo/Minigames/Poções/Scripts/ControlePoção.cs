using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMinigamePoção : MonoBehaviour
{
    private void Update()
    {
        SequênciaIngredientes();
    }

    void SequênciaIngredientes ()
    {
        if (Caldeirao.primeiroIngredienteCerto == true && Caldeirao.segundoIngredienteCerto == true && Caldeirao.terceiroIngredienteCerto == true)
        {
            JogadorGanhou();
        }
    }

    void JogadorGanhou ()
    {
        SceneManager.LoadScene("QuartoSelene");
        Debug.Log("Parabéns! Agora o sangue da Selene não estará mais nas suas mãos!");
    }

    void JogadorPerdeu ()
    {
        SceneManager.LoadScene("CenaDerrota");
        Debug.Log("Assassino!");
    }
}