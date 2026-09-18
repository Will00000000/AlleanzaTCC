using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalizar : MonoBehaviour
{
    public List<Drop> drops; //lista de encaixes para as peças
    int pecasCertas; //Quantidade de peças que estão encaixadas certo

    public GameObject telaMontada;

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

        telaMontada.SetActive(true);
    }
}