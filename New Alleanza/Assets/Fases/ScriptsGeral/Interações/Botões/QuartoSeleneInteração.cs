using UnityEngine;

public class QuartoSeleneInteração : MonoBehaviour
{
    GameObject jogador;

    public GameObject GoCastelo;
    public GameObject GoPocoes;

    [Header("EntreCenas")]
    float distancia_GoCastelo;
    float distancia_GoPocoes;

    private void Start()
    {
        jogador = GameObject.Find("Mellory");
    }

    private void Update()
    {
        distancia_GoCastelo = Vector2.Distance(jogador.transform.position, GoCastelo.transform.position);
        distancia_GoPocoes = Vector2.Distance(jogador.transform.position, GoPocoes.transform.position);

        InteraçãoEntreCenas ();
        InteracaoGoMinigames ();
    }

    private void InteraçãoEntreCenas ()
    {
        if (distancia_GoCastelo < 5)
        {
            GoCastelo.SetActive(true);
        }
        else
        {
            GoCastelo.SetActive(false);
        }
    }

    private void InteracaoGoMinigames ()
    {
        if (distancia_GoPocoes < 5)
        {
            GoPocoes.SetActive (true);
        }
        else
        {
            GoPocoes.SetActive (false);
        }
    }
}
