using UnityEngine;

public class Receita : MonoBehaviour
{
    bool aberto = false;

    Animator anima;

    private void Start()
    {
        anima = GetComponent<Animator>();
    }

    public void AbrirReceita()
    {
        aberto = !aberto;

        if (aberto)
        {
            anima.SetBool("Abrir", false);
        }
        else
        {
            anima.SetBool("Abrir", true);
        }
    }
}
