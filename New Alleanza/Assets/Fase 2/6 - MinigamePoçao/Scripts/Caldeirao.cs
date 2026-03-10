using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    public ParticleSystem fumaca;

    void Start()
    {
        // garante que a fumaça não comece ativa
        if (fumaca != null)
        {
            fumaca.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ingrediente"))
        {
            Debug.Log("Ingrediente adicionado: " + other.name);

            // ativa a fumaça
            if(fumaca != null)
            {
                fumaca.Play();

                // para a fumaça depois de 2 segundos
                Invoke("PararFumaca", 2f);
            }

            Destroy(other.gameObject);
        }
    }

    void PararFumaca()
    {
        if (fumaca != null)
        {
            fumaca.Stop();
        }
    }
}