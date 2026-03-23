using UnityEngine;
using UnityEngine.UI;

public class Dialogo : MonoBehaviour
{
    public GameObject caixaDialogo;
    public Text textoDialogo;

    [TextArea]
    public string[] falas;

    int index = 0;
    bool dialogoAtivo = false;

    void Update()
    {
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            ProximaFala();
        }
    }

    public void IniciarDialogo()
    {
        caixaDialogo.SetActive(true);
        Time.timeScale = 0f; // pausa o jogo

        dialogoAtivo = true;
        index = 0;

        textoDialogo.text = falas[index];
    }

    void ProximaFala()
    {
        index++;

        if (index < falas.Length)
        {
            textoDialogo.text = falas[index];
        }
        else
        {
            EncerrarDialogo();
        }
    }

    void EncerrarDialogo()
    {
        caixaDialogo.SetActive(false);
        Time.timeScale = 1f; // volta o jogo

        dialogoAtivo = false;
    }
}