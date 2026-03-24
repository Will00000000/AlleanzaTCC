using UnityEngine;

public class Interacao : MonoBehaviour
{
    public Dialogo dialogo;

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            dialogo.IniciarDialogo();
        }
    }
}