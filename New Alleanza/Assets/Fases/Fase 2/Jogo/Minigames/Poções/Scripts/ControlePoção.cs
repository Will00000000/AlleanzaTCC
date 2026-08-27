using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlePoção : MonoBehaviour
{
    private void Update()
    {
        if (Caldeirao.primeiroIngrediente == true)
        {
            if (Caldeirao.segundoIngrediente == true)
            {
                if (Caldeirao.terceiroIngrediente == true)
                {
                    SceneManager.LoadScene("QuartoSelene");
                    Debug.Log("Parabéns! Agora o sangue da Selene não estará mais nas suas mãos!");
                }
            }
        }
    }
}