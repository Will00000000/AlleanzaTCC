using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    public ParticleSystem fumaca;

    public static bool primeiroIngredienteCerto = false; //primeiro ingrediente certo
    public static bool segundoIngredienteCerto = false; //segundo ingrediente certo
    public static bool terceiroIngredienteCerto = false; //terceiro ingrediente certo

    public static bool ingredienteEncostou;

    //QUANTIDADE DE INGREDIENTES JOGADOS ATÉ O MOMENTO
    
    public static bool jogadorGanhou;

    public bool ingredienteDestruído;

    void Start()
    {
        // garante que a fumaça não comece ativa
        if (fumaca != null)
        {
            fumaca.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D col) // método de verificação de colisão
    {
        if (col.gameObject.tag == "Ingrediente") // se o caldeirão detectar um ingrediente...
        {
            Destroy (col.gameObject);

            if (ControleMinigamePoção.ingredienteJogado_1 == false && ControleMinigamePoção.ingredienteJogado_2 == false)
            {
                ControleMinigamePoção.VerificaçãoLimiteIngredientes ();

                Debug.Log("Ingrediente adicionado: " + col.name);

                // ... ativa a fumaça
                if (fumaca != null)
                {
                    fumaca.Play();

                    // para a fumaça depois de 2 segundos
                    Invoke("PararFumaca", 2f);
                }

                ControleMinigamePoção.ingredienteJogado_1 = true;

                //VERIFICAÇÃO DE INGREDIENTES E ORDEM CORRETOS
                if (col.name == "Ingrediente4 (certo)") // ... e se o nome do ingrediente colidido for o ingrediente 4...
                {
                    primeiroIngredienteCerto = true; //... então o primeiro ingrediente necessário para a poção será misturado.
                }

                if (primeiroIngredienteCerto == true && col.name == "Ingrediente6 (certo)") // ... e se o primeiro ingrediente já estiver na mistura e o nome do ingrediente colidido for o ingrediente 6...
                {
                    segundoIngredienteCerto = true; //... então o segundo ingrediente necessário para a poção será misturado.  
                }

                if (segundoIngredienteCerto == true && segundoIngredienteCerto == true && col.name == "Ingrediente7 (certo)") //... e se o segundo ingrediente já estiver na mistura e o nome do ingrediente colidido for o ingrediente 8...
                {
                    terceiroIngredienteCerto = true; //... então o terceiro ingrediente necessário para a poção será misturado.
                }
                
                ingredienteDestruído = true; //... e diz à variável que o ingrediente jogado foi destruído
            }
            else if (ControleMinigamePoção.ingredienteJogado_1 == true)
            {
                ControleMinigamePoção.ingredienteJogado_1 = false;
                ControleMinigamePoção.ingredienteJogado_2 = true;
            }
            else if (ControleMinigamePoção.ingredienteJogado_1 == false && ControleMinigamePoção.ingredienteJogado_2 == true)
            {
                ControleMinigamePoção.ingredienteJogado_2 = false;
                ControleMinigamePoção.ingredienteJogado_3 = true;
            }

            ControleMinigamePoção.VerificaçãoLimiteIngredientes ();
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