using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public List<GameObject> slots;

    public Sprite poema;

    private void Update ()
    {
        if (PraiaManager.pegouPoema == true) // se o jogador pegou o poema...
        {
            LimparSlots(); // ... limpa-se os slots
            CarregarPoema(); // ... chama a função de carregamento
        }
    }

    private void LimparSlots () // função para limpar todos os slots
    {
        for (int i = 0; i < slots.Count; i++)
        {
            slots[i].GetComponent<Image>().sprite = null;
        }
    }

    private void CarregarPoema () // põe o sprite do poema no primeiro slot
    {
        slots[1].GetComponent<Image>().sprite = poema;
    }
}