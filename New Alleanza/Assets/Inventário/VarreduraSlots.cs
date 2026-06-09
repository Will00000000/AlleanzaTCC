using UnityEngine;
using UnityEngine.UI;

public class VarreduraSlots : Singleton<VarreduraSlots>
{
    public Image[] slot;

    public GameObject script_coleta;
    public GerenciadorDescricao script_descricao;

    private void Update()
    {
        script_coleta = GameObject.Find("InteractController");

        Color novaCor;

        #region Slot 1
        if (slot[0].sprite == null)
        {
            slot[0].sprite = script_coleta.GetComponent<Coleta>().spriteItem;

            script_descricao = GetComponent<GerenciadorDescricao>();
        }
        #endregion

        #region Slot 2
        else if (slot[1].sprite == null)
        {
            novaCor = slot[0].color;
            novaCor.a = 1f;
            slot[0].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                slot[1].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
            }
        }
        #endregion

        #region Slot 3
        else if (slot[2].sprite == null)
        {
            novaCor = slot[1].color;
            novaCor.a = 1f;
            slot[1].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    slot[2].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
                }
            }
        }
        #endregion

        #region Slot 4
        else if (slot[3].sprite == null)
        {
            novaCor = slot[2].color;
            novaCor.a = 1f;
            slot[2].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        slot[3].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
                    }
                }
            }
        }
        #endregion

        #region Slot 5
        else if (slot[4].sprite == null)
        {
            novaCor = slot[3].color;
            novaCor.a = 1f;
            slot[3].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                        {
                            slot[4].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
                        }
                    }
                }
            }
        }
        #endregion

        #region Slot 6
        else if (slot[5].sprite == null)
        {
            novaCor = slot[4].color;
            novaCor.a = 1f;
            slot[4].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                            {
                                slot[5].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
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
            novaCor = slot[5].color;
            novaCor.a = 1f;
            slot[5].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                {
                                    slot[6].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
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
            novaCor = slot[6].color;
            novaCor.a = 1f;
            slot[6].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                {
                                    if (slot[6].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                    {
                                        slot[7].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
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
            novaCor = slot[7].color;
            novaCor.a = 1f;
            slot[7].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                if (slot[1].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                {
                    if (slot[2].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                    {
                        if (slot[3].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                        {
                            if (slot[4].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                            {
                                if (slot[5].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                {
                                    if (slot[6].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                    {
                                        if (slot[7].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
                                        {
                                            slot[8].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
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

        else
        {
            novaCor = slot[8].color;
            novaCor.a = 1f;
            slot[8].color = novaCor;
        }
    }
}