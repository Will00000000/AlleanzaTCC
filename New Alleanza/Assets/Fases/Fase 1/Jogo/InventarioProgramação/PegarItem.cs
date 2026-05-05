/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PegarItem : MonoBehaviour
{
    public GameObject itemPrefab;
    private Inventario inventario;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        inventario = FindObjectOfType<Inventario>(); //procura o script na cena
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnMouseDown()
    {
        if (inventario != null && spriteRenderer != null)
        {
            bool itemAdicionado = inventario.AdicionarItem(itemPrefab, spriteRenderer.sprite); //não entendi

            if (itemAdicionado)
            {
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Inventário cheio! Não é possível adicionar mais itens.");
            }
        }
    }
}*/