using UnityEngine;

public class CasteloInteração : MonoBehaviour
{
    public GameObject GoAtlantis;
    public GameObject GoQuartoSelene;

    GameObject jogador;

    [Header("EntreCenas")]
    float distancia_GoAtlantis;
    float distancia_GoQuartoSelene;

    private void Start()
    {
        jogador = GameObject.Find("Mellory");
    }

    void Update()
    {
        distancia_GoAtlantis = Vector2.Distance(jogador.transform.position, GoAtlantis.transform.position);
        distancia_GoQuartoSelene = Vector2.Distance(jogador.transform.position, GoQuartoSelene.transform.position);

        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas()
    {
        if (distancia_GoAtlantis < 5)
        {
            GoAtlantis.SetActive(true);
        }
        else
        {
            GoAtlantis.SetActive(false);
        }

        if (distancia_GoQuartoSelene < 5)
        {
            GoQuartoSelene.SetActive(true);
        }
        else
        {
            GoQuartoSelene.SetActive(false);
        }
    }
}