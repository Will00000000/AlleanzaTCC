using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    public ParticleSystem fumaca;

    public static bool primeiroIngredienteCerto = false; //primeiro ingrediente certo
    public static bool segundoIngredienteCerto = false; //segundo ingrediente certo
    public static bool terceiroIngredienteCerto = false; //terceiro ingrediente certo

    public static bool jogadorGanhou;

    public static bool ingredienteDestruído;

    void Start()
    {
        // garante que a fumaça não comece ativa
        if (fumaca != null)
        {
            fumaca.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Ingrediente")
        {
            Debug.Log("Ingrediente adicionado: " + col.name);

            // ativa a fumaça
            if (fumaca != null)
            {
                fumaca.Play();

                // para a fumaça depois de 2 segundos
                Invoke("PararFumaca", 2f);
            }

            if (col.name == "Ingrediente4 (certo)") //se o nome do ingrediente colidido for o ingrediente 4...
            {
                primeiroIngredienteCerto = true; //o primeiro ingrediente necessário para a poção será misturado.
            }

            if (primeiroIngredienteCerto == true && col.name == "Ingrediente6 (certo)") //se o primeiro ingrediente estiver na mistura e o nome do ingrediente colidido for o ingrediente 6...
            {
                segundoIngredienteCerto = true; //o segundo ingrediente necessário para a poção será misturado.  
            }

            if (segundoIngredienteCerto == true && segundoIngredienteCerto == true && col.name == "Ingrediente7 (certo)") //se o segundo ingrediente estiver na mistura e o nome do ingrediente colidido for o ingrediente 8...
            {
                terceiroIngredienteCerto = true; //o terceiro ingrediente necessário para a poção será misturado.
            }

            Destroy(col.gameObject);
            ingredienteDestruído = true; //diz a variável que o ingrediente jogado foi destruído
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