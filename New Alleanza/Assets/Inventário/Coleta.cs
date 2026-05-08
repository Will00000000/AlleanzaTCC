using UnityEngine;
using UnityEngine.UI;

public class Coleta : MonoBehaviour
{
    GameObject jogador;
    [SerializeField] GameObject botaoPeca, peca;
    public float distancia_jogador;

    [HideInInspector]
    public Sprite sprite_Peca; //sprite da peça coletada

    void Start ()
    {
        jogador = GameObject.Find("Jogador");

        sprite_Peca = peca.GetComponent<Image>().sprite; //pega o sprite da peça e atribui à variável
    }

    void Update ()
    {
        distancia_jogador = Vector2.Distance(peca.transform.position, jogador.transform.position);

        if (distancia_jogador < 2)
        {
            botaoPeca.SetActive(true);
        }
        else
        {
            botaoPeca.SetActive(false);
        }
    }

    public void Coletar_Peca ()
    {
        Destroy(gameObject);
    }
}