using UnityEngine;

public class Interacao : MonoBehaviour
{
    public Dialogo dialogo;

    bool jaAtivado = false; //controla se já foi usado

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player") && !jaAtivado)
        {
            dialogo.IniciarDialogo();

            jaAtivado = true; // não ativa novamente
        }
    }
}