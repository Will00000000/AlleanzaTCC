using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class VarreduraSlots : MonoBehaviour
{
    public List<Image> slot;

    Color novaCor;
    public GameObject script_coleta;

    private void Start()
    {
        script_coleta = GameObject.Find("InteractController");

        novaCor.a = 0f;
    }

    private void Update()
    {
        Slots();

        novaCor.a = 0f;
        novaCor.r = 1f;
        novaCor.g = 1f;
        novaCor.b = 1f;
    }

    private void Slots ()
    {
        #region Slot 1
        if (slot[0].sprite == null) // se o primeiro slot estiver vazio...
        {
            slot[0].sprite = script_coleta.GetComponent<Coleta>().spriteItem; //... o slot recebe o sprite do item mais recente
            slot[0].preserveAspect = true;

            novaCor.a = 0f;
            slot[0].color = novaCor; // ...  e deixa de ser transparente

            Debug.Log("Slot 1 est� vazio");
        }
        #endregion

        #region Slot 2
        else if (slot[1].sprite == null)
        {
            novaCor.a = 1f;
            slot[0].color = novaCor;

            if (slot[0].sprite != script_coleta.GetComponent<Coleta>().spriteItem)
            {
                slot[1].sprite = script_coleta.GetComponent<Coleta>().spriteItem;
            }

            Debug.Log("Slot 2 est� vazio");
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
    }
}