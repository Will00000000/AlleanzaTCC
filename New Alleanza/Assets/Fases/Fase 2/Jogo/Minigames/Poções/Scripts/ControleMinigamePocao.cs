using UnityEngine;
using UnityEngine.SceneManagement;

public class ControleMinigamePocao : MonoBehaviour
{
    public GameObject Caldeirão;

    //VERIFICAÇÃO DE QUANTIDADE DE INGREDIENTES
    public static bool ultimoIngredienteJogado_1;
    public static bool ultimoIngredienteJogado_2;
    public static bool ultimoIngredienteJogado_3;

    private void Start ()
    {
        ultimoIngredienteJogado_1 = false;
        ultimoIngredienteJogado_2 = false;
        ultimoIngredienteJogado_3 = false;
    }

    public void VerificaçãoLimiteIngredientes ()
    {
        if (ultimoIngredienteJogado_1 == true)
        {
            Debug.Log ("Joguei o primeiro ingrediente");
        }

        if (ultimoIngredienteJogado_2 == true)
        {
            Debug.Log ("Joguei o segundo ingrediente");
        }

        if (ultimoIngredienteJogado_3 == true)
        {
            Debug.Log ("Joguei o terceiro ingrediente");

            if (Caldeirao.primeiroIngredienteCerto == true && Caldeirao.segundoIngredienteCerto == true && Caldeirao.terceiroIngredienteCerto == true)
            {
                JogadorGanhou();
            }
            else
            {
                JogadorPerdeu();
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