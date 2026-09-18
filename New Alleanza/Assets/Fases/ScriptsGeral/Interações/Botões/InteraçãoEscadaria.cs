using UnityEngine;

public class InteracaoEscadaria : MonoBehaviour
{
    public GameObject placa;
    public GameObject OpenPlaca;
    public GameObject jogador;
    public GameObject InterfaceGeral;

    [Header("EntreCenas")]
    public GameObject GoPraia2;
    public GameObject GoCidade;

    [Header("Distância de Interação")]
    public float distanciaInteracao = 5f;

    private float distancia_GoPraia2;
    private float distancia_GoCidade;
    private float distancia_OpenPlaca;

    // Controla se o jogador já interagiu com a placa na cena atual
    private bool placaFoiLida = false;

    private void Start()
    {
        BuscarJogador();

        // Garante que o estado inicial ao entrar na cena comece limpo
        placaFoiLida = false;

        // Descomente abaixo se quiser que o jogo lembre que a placa já foi lida mesmo trocando de cena:
        // placaFoiLida = PlayerPrefs.GetInt("Abriu placa", 0) == 1;
    }

    private void Update()
    {
        if (jogador == null)
        {
            BuscarJogador();
            if (jogador == null) return; // Se ainda assim não achar, ignora o Update
        }

        // Calcula as distâncias com proteção contra objetos não atribuídos no Inspector
        if (GoPraia2 != null)
            distancia_GoPraia2 = Vector2.Distance(jogador.transform.position, GoPraia2.transform.position);

        if (GoCidade != null)
            distancia_GoCidade = Vector2.Distance(jogador.transform.position, GoCidade.transform.position);

        if (OpenPlaca != null)
            distancia_OpenPlaca = Vector2.Distance(jogador.transform.position, OpenPlaca.transform.position);

        InteracaoEntreCenas();
    }

    private void BuscarJogador()
    {
        jogador = GameObject.Find("Morgan");

        if (jogador == null)
        {
            GameObject objTag = GameObject.FindGameObjectWithTag("Player");
            if (objTag != null) jogador = objTag;
        }
    }

    private void InteracaoEntreCenas()
    {
        // 1. Botão para Ir à Praia 2 (liberado por proximidade)
        if (GoPraia2 != null)
        {
            GoPraia2.SetActive(distancia_GoPraia2 < distanciaInteracao);
        }

        // 2. Botão para Abrir Placa (só aparece se estiver perto E ainda NÃO tiver lido)
        if (OpenPlaca != null)
        {
            OpenPlaca.SetActive(distancia_OpenPlaca < distanciaInteracao && !placaFoiLida);
        }

        // 3. Botão para Ir à Cidade (só aparece se estiver perto E JÁ tiver lido a placa)
        if (GoCidade != null)
        {
            GoCidade.SetActive(distancia_GoCidade < distanciaInteracao && placaFoiLida);
        }
    }

    public void AbrirPlaca()
    {
        if (placa != null) placa.SetActive(true);
        if (InterfaceGeral != null) InterfaceGeral.SetActive(false);

        // Marca que a placa foi lida para liberar o botão da cidade e ocultar o da placa
        placaFoiLida = true;
        PlayerPrefs.SetInt("Abriu placa", 1);
        PlayerPrefs.Save();
    }

    public void FecharPlaca()
    {
        if (placa != null) placa.SetActive(false);
        if (InterfaceGeral != null) InterfaceGeral.SetActive(true);
    }
}