using UnityEngine;
using TMPro;

public class Dialogo : MonoBehaviour
{
    public GameObject caixaDialogo;
    public TMP_Text textoDialogo;

    //referência ao jogador (arrastar no Inspector)
    public Jogador2D_Terra jogador;

    [TextArea]
    public string[] falas;

    int index = 0;
    bool dialogoAtivo = false;

    void Update()
    {
        //só permite avançar diálogo se ele estiver ativo
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            ProximaFala();
        }
    }

    public void IniciarDialogo()
    {
        caixaDialogo.SetActive(true);

        Time.timeScale = 0f; // pausa o tempo do jogo

        dialogoAtivo = true;
        index = 0;

        // trava o movimento do jogador
        if (jogador != null)
        {
            jogador.podeMover = false;
        }

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

        Time.timeScale = 1f; //volta o tempo ao normal

        dialogoAtivo = false;

        // libera o movimento do jogador novamente
        if (jogador != null)
        {
            jogador.podeMover = true;
        }
    }
}