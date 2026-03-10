using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ingrediente"))
        {
            Debug.Log("Ingrediente adicionado: " + other.name);
            Destroy(other.gameObject);
        }
    }
}