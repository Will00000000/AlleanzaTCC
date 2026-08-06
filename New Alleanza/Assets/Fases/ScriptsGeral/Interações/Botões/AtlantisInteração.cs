using UnityEngine;

public class AtlantisInteração : MonoBehaviour
{
    public GameObject GoPraia;
    public GameObject GoCastelo;

    GameObject jogador;

    [Header("EntreCenas")]
    float distancia_GoPraia;
    float distancia_GoCastelo;

    private void Start()
    {
        jogador = GameObject.Find("Morgan");
    }

    void Update()
    {
        distancia_GoPraia = Vector2.Distance(jogador.transform.position, GoPraia.transform.position);
        distancia_GoCastelo = Vector2.Distance(jogador.transform.position, GoCastelo.transform.position);

        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas()
    {
        if (distancia_GoPraia < 5 && PlayerPrefs.GetInt ("Visitou o quarto de Selene", 0) == 1)
        {
            GoPraia.SetActive(true);
        }
        else
        {
            GoPraia.SetActive(false);
        }

        if (distancia_GoCastelo < 5)
        {
            GoCastelo.SetActive(true);
        }
        else
        {
            GoCastelo.SetActive(false);
        }
    }
}