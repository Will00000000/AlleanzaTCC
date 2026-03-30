using UnityEngine;
using TMPro;
using System.Collections; // necessário para usar digitação

public class Dialogo : MonoBehaviour
{
    public GameObject caixaDialogo;
    public TMP_Text textoDialogo;

    public Jogador2D_Terra jogador;

    [TextArea]
    public string[] falas;

    public float velocidadeTexto = 0.05f; // velocidade da digitação

    int index = 0;
    bool dialogoAtivo = false;

    bool estaDigitando = false; // verifica se o texto ainda está sendo escrito

    void Update()
    {
        // só permite avançar diálogo se ele estiver ativo
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            if (estaDigitando) // se ainda estiver digitando...
            {
                StopAllCoroutines(); // para a digitação atual
                textoDialogo.text = falas[index]; // mostra o texto completo na hora
                estaDigitando = false; // finaliza o estado de digitação
            }
            else
            {
                ProximaFala(); // vai para a próxima fala
            }
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

        StartCoroutine(DigitarTexto()); // inicia o efeito de digitação
    }

    IEnumerator DigitarTexto()
    {
        estaDigitando = true; // indica que está digitando
        textoDialogo.text = ""; // limpa o texto antes de começar

        // percorre cada letra da fala atual
        foreach (char letra in falas[index])
        {
            textoDialogo.text += letra; // adiciona uma letra por vez
            yield return new WaitForSecondsRealtime(velocidadeTexto); // espera um tempo
        }

        estaDigitando = false; // terminou de digitar
    }

    void ProximaFala()
    {
        index++; // vai para a próxima fala

        if (index < falas.Length)
        {
            StartCoroutine(DigitarTexto()); // inicia digitação da nova fala
        }
        else
        {
            EncerrarDialogo(); // se acabou, fecha o diálogo
        }
    }

    void EncerrarDialogo()
    {
        caixaDialogo.SetActive(false);

        Time.timeScale = 1f; // volta o tempo ao normal

        dialogoAtivo = false;

        // libera o movimento do jogador novamente
        if (jogador != null)
        {
            jogador.podeMover = true;
        }
    }
}