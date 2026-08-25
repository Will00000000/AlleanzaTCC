using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    public ParticleSystem fumaca;

    public static bool primeiroIngrediente = false; //primeiro ingrediente certo
    public static bool segundoIngrediente = false; //segundo ingrediente certo
    public static bool terceiroIngrediente = false; //terceiro ingrediente certo

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

            if (other.name == "Ingrediente1 (certo)")
            {
                primeiroIngrediente = true;
            }

            if (other.name == "Ingrediente2 (certo)")
            {
                segundoIngrediente = true;
            }

            if (other.name == "Ingrediente3 (certo)")
            {
                terceiroIngrediente = true;
            }
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