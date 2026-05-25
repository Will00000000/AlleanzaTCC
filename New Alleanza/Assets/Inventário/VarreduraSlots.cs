using UnityEngine;
using UnityEngine.UI;

public class VarreduraSlots : MonoBehaviour
{
    public Image [] slot;

    public Coleta script_coleta;

    private void Update()
    {
        #region Slot 1
        if (slot[0].sprite == null)
        {
            slot[0].sprite = script_coleta.spriteItem;
        }
        #endregion

        #region Slot 2
        else if (slot[1].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                slot[1].sprite = script_coleta.spriteItem;
            }
        }
        #endregion

        #region Slot 3
        else if (slot[2].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    slot[2].sprite = script_coleta.spriteItem;
                }
            }
        }
        #endregion

        #region Slot 4
        else if (slot[3].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        slot[3].sprite = script_coleta.spriteItem;
                    }
                }
            }
        }
        #endregion

        #region Slot 5
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
        }
        #endregion

        #region Slot 6
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
                            if (slot[4].sprite != script_coleta.spriteItem)
                            {
                                slot[5].sprite = script_coleta.spriteItem;
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Slot 7
        else if (slot[6].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.spriteItem)
                                {
                                    slot[6].sprite = script_coleta.spriteItem;
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Slot 8
        else if (slot[7].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.spriteItem)
                                {
                                    if (slot[6].sprite != script_coleta.spriteItem)
                                    {
                                        slot[7].sprite = script_coleta.spriteItem;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Slot 9
        else if (slot[8].sprite == null)
        {
            if (slot[0].sprite != script_coleta.spriteItem)
            {
                if (slot[1].sprite != script_coleta.spriteItem)
                {
                    if (slot[2].sprite != script_coleta.spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.spriteItem)
                                {
                                    if (slot[6].sprite != script_coleta.spriteItem)
                                    {
                                        if (slot[7].sprite != script_coleta.spriteItem)
                                        {
                                            slot[8].sprite = script_coleta.spriteItem;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion
    }
}