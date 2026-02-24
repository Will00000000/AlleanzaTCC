/*using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Transform[] slots; //lista que armazena as posições dos slots;

    public bool AdicionarItem(GameObject itemPrefab, GameObject itemSprite)
    {
        foreach (var slot in slots)
        {
            if (slot.childCount == 0)
            {
                GameObject item = Instantiate(itemPrefab, slot);
                item.GetComponent<ArrastaItem>().parentDepoisArrastar = slot;

                Image itemImage = item.GetComponent<Image>();
                if (itemImage != null && itemSprite != null)
                {
                    itemImage.sprite = itemSprite;
                }
                return true;
            }
        }
        return false;
    }
}*/