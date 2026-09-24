using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<Image> botoesSlots;
    int slotsLimpos; // quantidade de slots que já foram limpos no laço abaixo

    public Sprite poema;

    public GameObject script_coleta;

    private void Start()
    {
        script_coleta = GameObject.Find ("InteractController");
    }

    private void Update ()
    {
        if (PlayerPrefs.GetInt ("Pegou o poema", 0) == 1) // se o jogador pegou o poema...
        {
            LimparSlots(); // ... limpa-se os slots
        }

        CarregarPoema();
    }

    private void LimparSlots () // função para limpar todos os slots
    {
        for (int i = 0; i < botoesSlots.Count; i++)
        {
            botoesSlots[i].sprite = null;

            slotsLimpos = slotsLimpos + 1;
        }
    }

    private void CarregarPoema () // põe o sprite do poema no primeiro slot
    {
        if (slotsLimpos == 9)
        {
            Debug.Log ("9 slots limpos");

            script_coleta.GetComponent<Coleta>().spriteItem = poema; // muda o sprite do primeiro slot

        }
    }
}