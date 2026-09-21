using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalizar : MonoBehaviour
{
    public List<Drop> drops; //lista de encaixes para as peças
    public List<DragDrop> pecas; //lista de peças
    int pecasCertas; //Quantidade de peças que estão encaixadas certo

    public GameObject telaMontada;
    public GameObject botaoSair;

    private void Update ()
    {
        VerificarCorretos ();
    }

    private void VerificarCorretos ()
    {
        pecasCertas = 0;

        for (int i = 0; i < drops.Count; i++)
        {
            if (drops[i].correta == true)
            {
                pecasCertas = pecasCertas + 1;
            }
        }

        if (pecasCertas == drops.Count && drops.Count > 0)
        {
            FinalizarJogo ();
        }
    }

    private void FinalizarJogo ()
    {
        TelaPronta();
    }

    private void TelaPronta ()
    {
        for (int i = 0; i < drops.Count; i++)
        {
            drops[i].gameObject.SetActive (false);
        }

        for (int i = 0; i < pecas.Count; i++)
        {
            pecas[i].gameObject.SetActive (false);
        }

        telaMontada.SetActive(true);
        botaoSair.SetActive(true);
    }
}