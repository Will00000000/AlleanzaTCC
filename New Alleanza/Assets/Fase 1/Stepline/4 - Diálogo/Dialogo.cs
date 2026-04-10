using UnityEngine;
using TMPro;
using System.Collections; // necessário para usar digitação

public class Dialogo : MonoBehaviour
{
    public GameObject caixaDialogo; // caixa original (Player1)
    public GameObject caixaPlayer2; // 🆕 caixa do segundo personagem

    public TMP_Text textoDialogo;

    public Jogador2D_Terra jogador;

    public Animator animator; // controla a animação da caixa

    [TextArea]
    public string[] falas;

    public int[] quemFala; // 🆕 0 = Player1 | 1 = Player2

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
                estaDigitando = false;
            }
            else
            {
                ProximaFala(); // vai para a próxima fala
            }
        }
    }

    void Start()
    {
        caixaDialogo.SetActive(false); // garante que começa escondido

        if (caixaPlayer2 != null)
        {
            caixaPlayer2.SetActive(false); // 🆕 começa escondido também
        }
    }

    public void IniciarDialogo()
    {
        caixaDialogo.SetActive(true);

        // 🎬 ativa animação de entrada
        if (animator != null)
        {
            animator.SetBool("Abrir", true);
        }

        Time.timeScale = 0f;

        dialogoAtivo = true;
        index = 0;

        // trava o movimento do jogador
        if (jogador != null)
        {
            jogador.podeMover = false;
        }

        MostrarQuemFala(); // 🆕 define quem aparece primeiro

        StartCoroutine(DigitarTexto());
    }

    IEnumerator DigitarTexto()
    {
        estaDigitando = true;
        textoDialogo.text = "";

        foreach (char letra in falas[index])
        {
            textoDialogo.text += letra;
            yield return new WaitForSecondsRealtime(velocidadeTexto);
        }

        estaDigitando = false;
    }

    void ProximaFala()
    {
        index++;

        if (index < falas.Length)
        {
            MostrarQuemFala(); // 🆕 troca a caixa conforme quem fala

            StartCoroutine(DigitarTexto());
        }
        else
        {
            EncerrarDialogo();
        }
    }

    // 🆕 MÉTODO NOVO
    void MostrarQuemFala()
    {
        if (quemFala[index] == 0)
        {
            caixaDialogo.SetActive(true); // Player1
            if (caixaPlayer2 != null)
                caixaPlayer2.SetActive(false);
        }
        else
        {
            caixaDialogo.SetActive(false);
            if (caixaPlayer2 != null)
                caixaPlayer2.SetActive(true); // Player2
        }
    }

    void EncerrarDialogo()
    {
        // 🎬 animação de saída
        if (animator != null)
        {
            animator.SetBool("Abrir", false);
        }

        StartCoroutine(FecharDepois());
    }

    IEnumerator FecharDepois()
    {
        textoDialogo.text = "";
        yield return new WaitForSecondsRealtime(-0.1f); // tempo da animação

        caixaDialogo.SetActive(false);

        if (caixaPlayer2 != null)
        {
            caixaPlayer2.SetActive(false); // garante que fecha tudo
        }

        Time.timeScale = 1f;

        dialogoAtivo = false;

        // libera o movimento do jogador novamente
        if (jogador != null)
        {
            jogador.podeMover = true;
        }
    }
}