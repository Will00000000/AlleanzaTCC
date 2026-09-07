using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMinigamePoção : MonoBehaviour
{
    public GameObject Caldeirão;

    //VERIFICAÇÃO DE QUANTIDADE DE INGREDIENTES
    public static bool ingredienteJogado_1 = false;
    public static bool ingredienteJogado_2 = false;
    public static bool ingredienteJogado_3 = false;

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

    public static void VerificaçãoLimiteIngredientes ()
    {
        if (ingredienteJogado_1 == true)
        {
            Debug.Log ("Joguei o primeiro ingrediente");
        }

        if (ingredienteJogado_2 == true)
        {
            Debug.Log ("Joguei o segundo ingrediente");
        }

        if (ingredienteJogado_3 == true)
        {
            Debug.Log ("Joguei o terceiro ingrediente");
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