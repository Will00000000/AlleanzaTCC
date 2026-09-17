using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finalizar : MonoBehaviour
{
    public List<Drop> drops; //lista de encaixes para as peças
    int pecasCertas; //Quantidade de peças que estão encaixadas certo

    private void Update ()
    {
        VerificarCorretos ();
    }

    private void VerificarCorretos ()
    {
        for (int i = 0; i < drops.Count; i++)
        {
            if (drops[i].correta == true)
            {
                pecasCertas = pecasCertas + 1;
                i = 0;
            }
        }

        if (pecasCertas == 26)
        {
            FinalizarJogo ();
        }
    }

    private void FinalizarJogo ()
    {
        SceneManager.LoadScene ("Museu");
    }
}