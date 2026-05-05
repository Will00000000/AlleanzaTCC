using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TempoMinigame : MonoBehaviour
{
    public Image barraTempo;
    public float tempoMaximo = 10f;

    float tempoAtual;

    void Start()
    {
        tempoAtual = tempoMaximo;
    }

    void Update()
    {
        tempoAtual -= Time.deltaTime;

        barraTempo.fillAmount = tempoAtual / tempoMaximo;

        if (tempoAtual <= 0)
        {
            Perdeu();
        }
    }

    void Perdeu()
    {
        SceneManager.LoadScene("CenaDerrota");
    }
}