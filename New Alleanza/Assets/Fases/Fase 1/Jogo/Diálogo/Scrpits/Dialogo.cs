using UnityEngine;
using TMPro;
using System.Collections;
using System.Collections.Generic; // Necessário para usar a Lista

public class Dialogo : MonoBehaviour
{
    // Lista estática: guarda os IDs concluídos durante toda a sessão do jogo
    private static HashSet<string> dialogosConcluidosGlobais = new HashSet<string>();

    [Header("Identificação Única")]
    public string idDialogo = "dialogo_01"; // Coloque um nome único no Inspector!

    public GameObject caixaDialogo;
    public GameObject caixaPlayer2;

    public GameObject button_PraiaDialogo;
    public GameObject button_MelloryDialogo;

    public TMP_Text textoDialogo;
    public Jogador2D_Terra jogador;
    public Animator animator;

    [TextArea]
    public string[] falas;
    public int[] quemFala;
    public float velocidadeTexto = 0.05f;

    int index = 0;
    bool dialogoAtivo = false;
    bool estaDigitando = false;

    [Header("Configuração de Acompanhante")]
    public SeguirJogador mellory;

    void Start()
    {
        caixaDialogo.SetActive(false);
        if (caixaPlayer2 != null) caixaPlayer2.SetActive(false);
    }

    void Update()
    {
        if (dialogoAtivo && Input.GetKeyDown(KeyCode.Space))
        {
            if (estaDigitando)
            {
                StopAllCoroutines();
                textoDialogo.text = falas[index];
                estaDigitando = false;
            }
            else
            {
                ProximaFala();
            }
        }
    }

    public void IniciarDialogo()
    {
        // 1. VERIFICAÇÃO: Se o ID deste diálogo já estiver na lista de concluídos, CANCELA!
        if (dialogosConcluidosGlobais.Contains(idDialogo))
        {
            return; 
        }

        caixaDialogo.SetActive(true);

        if (animator != null) animator.SetBool("Abrir", true);

        Time.timeScale = 0f;
        dialogoAtivo = true;
        index = 0;

        if (jogador != null) jogador.podeMover = false;

        MostrarQuemFala();
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
            MostrarQuemFala();
            StartCoroutine(DigitarTexto());
        }
        else
        {
            EncerrarDialogo();
        }
    }

    void MostrarQuemFala()
    {
        if (quemFala[index] == 0)
        {
            caixaDialogo.SetActive(true);
            if (caixaPlayer2 != null) caixaPlayer2.SetActive(false);
        }
        else
        {
            caixaDialogo.SetActive(false);
            if (caixaPlayer2 != null) caixaPlayer2.SetActive(true);
        }
    }

    void EncerrarDialogo()
    {
        if (animator != null) animator.SetBool("Abrir", false);
        StartCoroutine(FecharDepois());
    }

    IEnumerator FecharDepois()
    {
        textoDialogo.text = "";
        yield return new WaitForSecondsRealtime(0.1f);

        caixaDialogo.SetActive(false);
        if (caixaPlayer2 != null) caixaPlayer2.SetActive(false);

        Time.timeScale = 1f;
        dialogoAtivo = false;

        // 2. REGISTRO: Adiciona o ID único deste diálogo na lista global
        if (!dialogosConcluidosGlobais.Contains(idDialogo))
        {
            dialogosConcluidosGlobais.Add(idDialogo);
        }

        if (jogador != null) jogador.podeMover = true;
        if (mellory != null) mellory.ComeçarASeguir();
    }
}