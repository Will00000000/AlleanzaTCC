using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SistemaVida : MonoBehaviour
{
    public Image coracao1;
    public Image coracao2;
    public Image coracao3;

    int vida = 3;

    public void TomarDano()
    {
        vida--;

        if (vida == 2)
            coracao3.enabled = false;

        if (vida == 1)
            coracao2.enabled = false;

        if (vida <= 0)
        {
            coracao1.enabled = false;
            Invoke("ReiniciarJogo", 1f);
        }
    }

    void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}