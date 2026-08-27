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
        if (other.CompareTag("Ingrediente"))
        {
            Debug.Log("Ingrediente adicionado: " + other.name);

            // ativa a fumaça
            if(fumaca != null)
            {
                fumaca.Play();

                // para a fumaça depois de 2 segundos
                Invoke("PararFumaca", 2f);
            }

            if (other.name == "Ingrediente4 (certo)") //se o nome do ingrediente colidido for o ingrediente 5...
            {
                primeiroIngrediente = true; //o primeiro ingrediente necessário para a poção será misturado.
            }

            if (primeiroIngrediente == true && other.name == "Ingrediente6 (certo)") //se o primeiro ingrediente estiver na mistura e o nome do ingrediente colidido for o ingrediente 7...
            {
                segundoIngrediente = true; //o segundo ingrediente necessário para a poção será misturado.
            }

            if (segundoIngrediente = true && other.name == "Ingrediente7 (certo)") //se o segundo ingrediente estiver na mistura e o nome do ingrediente colidido for o ingrediente 8...
            {
                terceiroIngrediente = true; //o terceiro ingrediente necessário para a poção será misturado.
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