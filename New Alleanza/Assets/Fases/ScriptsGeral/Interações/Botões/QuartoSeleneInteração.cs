using UnityEngine;

public class QuartoSeleneInteração : MonoBehaviour
{
    GameObject jogador;

    public GameObject GoCastelo;

    [Header("EntreCenas")]
    float distancia_GoCastelo;

    private void Start()
    {
        jogador = GameObject.Find("Morgan");
    }

    private void Update()
    {
        distancia_GoCastelo = Vector2.Distance(jogador.transform.position, GoCastelo.transform.position);

        InteraçãoEntreCenas();
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
}
