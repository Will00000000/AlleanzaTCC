using UnityEngine;
using UnityEngine.UI;

public class VarreduraSlots : MonoBehaviour
{
    public Image[] slot; //lista das imagens de cada um dos slots

    public GameObject script_coleta; //variável que pega o objeto que contém o script de coleta de um item; para assim acessar o script dentro dele e acessar o sprite do último item coletado

    private void Update()
    {
        script_coleta = GameObject.Find("InteractController");

        #region Slot 1
        if (slot[0].sprite == null) //se o o sprite do slot 1 estiver vazio...
        {
            slot[0].sprite = script_coleta.GetComponent<Coleta>().spriteItem; //...sprite do slot 1 vira o sprite do útlimo item coletado
        }
        #endregion

        #region Slot 2
        else if (slot[1].sprite == null)
        {
            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                slot[1].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
            }
        }
        #endregion

        #region Slot 3
        else if (slot[2].sprite == null)
        {
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
    }
}