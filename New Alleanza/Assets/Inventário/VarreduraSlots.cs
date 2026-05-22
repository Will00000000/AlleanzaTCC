using UnityEngine;
using UnityEngine.UI;

public class VarreduraSlots : MonoBehaviour
{
    public Image [] slot;

    public Coleta script_coleta;

    private void Update()
    {
        if (slot[0].sprite == null)
        {
            Debug.Log("slot 1 livre");
            
            slot[0].sprite = script_coleta.spriteItem;
        }
        else if (slot[1].sprite == null)
        {
            Debug.Log("slot 2 livre");

            if (slot[0].sprite != script_coleta.spriteItem)
            {
                slot[1].sprite = script_coleta.spriteItem;
            }
        }
        else if (slot[2].sprite == null)
        {
            Debug.Log("slot 3 livre");

            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    slot[2].sprite = script_coleta.spriteItem;
                }
            }
        }
        else if (slot[3].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        slot[3].sprite = script_coleta.spriteItem;
                        Debug.Log("slot 3 livre");
                    }
                }
            }
        }
        else if (slot[4].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.spriteItem)
                        {
                            slot[4].sprite = script_coleta.spriteItem;
                        }
                    }
                }
            }

            Debug.Log("slot 3 livre");
        }
        else if (slot[5].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.spriteItem)
                        {
                            slot[4].sprite = script_coleta.spriteItem;
                        }
                    }
                }
            }
            Debug.Log("slot 6 livre");
            slot[5].sprite = script_coleta.spriteItem;
        }
        else if (slot[6].sprite == null)
        {
            Debug.Log("slot 7 livre");
            slot[6].sprite = script_coleta.spriteItem;
        }
        else if (slot[7].sprite == null)
        {
            Debug.Log("slot 8 livre");
            slot[7].sprite = script_coleta.spriteItem;
        }
        else if (slot[8].sprite == null)
        {
            Debug.Log("slot 9 livre");
            slot[8].sprite = script_coleta.spriteItem;
        }
    }
}