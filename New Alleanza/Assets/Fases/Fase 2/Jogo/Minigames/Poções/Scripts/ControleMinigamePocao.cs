using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMinigamePocao : MonoBehaviour
{
    public GameObject Caldeirão;

    //VERIFICAÇÃO DE QUANTIDADE DE INGREDIENTES
    public static bool ingredienteJogado_1 = false;
    public static bool ingredienteJogado_2 = false;
    public static bool ingredienteJogado_3 = false;

    public void VerificaçãoLimiteIngredientes ()
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

            if (Caldeirao.primeiroIngredienteCerto == true && Caldeirao.segundoIngredienteCerto == true && Caldeirao.terceiroIngredienteCerto == true)
            {
                JogadorGanhou();
            }
            else
            {
                JogadorPerdeu();

                ingredienteJogado_1 = false;
                ingredienteJogado_2 = false;
                ingredienteJogado_3 = false;
            }
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