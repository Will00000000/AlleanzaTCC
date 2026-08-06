using UnityEngine;

public class InteraçãoEscadaria : MonoBehaviour
{
    public GameObject placa;
    public GameObject OpenPlaca;
    public GameObject jogador;
    public GameObject InterfaceGeral;

    [Header("EntreCenas")]
    public GameObject GoPraia2;
    public GameObject GoCidade;

    float distancia_GoPraia2;
    float distancia_GoCidade;
    float distancia_OpenPlaca;

    private void Start()
    {
        jogador = GameObject.Find("Morgan");
    }

    private void Update()
    {
        distancia_GoPraia2 = Vector2.Distance(jogador.transform.position, GoPraia2.transform.position);
        distancia_GoCidade = Vector2.Distance(jogador.transform.position, GoCidade.transform.position);
        distancia_OpenPlaca = Vector2.Distance(jogador.transform.position, OpenPlaca.transform.position);

        InteracaoEntreCenas();
    }

    private void InteracaoEntreCenas()
    {
        if (distancia_GoPraia2 < 5)
        {
            GoPraia2.SetActive(true);
        }
        else
        {
            GoPraia2.SetActive(false);
        }

        if (distancia_GoCidade < 5)
        {
            GoCidade.SetActive(true);
        }
        else
        {
            GoCidade.SetActive(false);
        }

        if (distancia_OpenPlaca < 5)
        {
            OpenPlaca.SetActive(true);
        }
        else
        {
            OpenPlaca.SetActive(false);
        }
    }

    public void AbrirPlaca ()
    {
        placa.SetActive (true);
        InterfaceGeral.SetActive (false);
    }

    public void FecharPlaca ()
    {
        placa.SetActive (false);
        InterfaceGeral.SetActive (true);
    }
}