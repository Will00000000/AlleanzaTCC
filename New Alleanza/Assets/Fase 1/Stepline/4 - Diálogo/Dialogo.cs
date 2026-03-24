using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public GameObject caixaDialogo;
    public TMP_Text textoDialogo;

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
        Time.timeScale = 0f;

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
        Time.timeScale = 1f;

        dialogoAtivo = false;
    }
}