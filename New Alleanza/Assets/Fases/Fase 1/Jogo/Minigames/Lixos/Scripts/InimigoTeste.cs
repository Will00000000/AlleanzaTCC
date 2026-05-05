using UnityEngine;

public class Dano : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("Player"))
        {
            FindObjectOfType<SistemaVida>().TomarDano();
        }
    }
}