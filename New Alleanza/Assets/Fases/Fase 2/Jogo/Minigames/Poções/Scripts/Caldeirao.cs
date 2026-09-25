using UnityEngine;

public class Caldeirao : MonoBehaviour
{
    public ParticleSystem fumaca;
    GameObject gameController;

    public static bool primeiroIngredienteCerto = false; //primeiro ingrediente certo
    public static bool segundoIngredienteCerto = false; //segundo ingrediente certo
    public static bool terceiroIngredienteCerto = false; //terceiro ingrediente certo

    public static bool ingredienteEncostou;

    //QUANTIDADE DE INGREDIENTES JOGADOS ATÉ O MOMENTO
    
    public static bool jogadorGanhou;

    public bool ingredienteDestruído;

    void Start()
    {
        gameController = GameObject.Find("GameController");

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

            if (ControleMinigamePocao.ultimoIngredienteJogado_1 == false && ControleMinigamePocao.ultimoIngredienteJogado_2 == false) // no primeiro ingrediente jogado
            {
                Debug.Log("Ingrediente adicionado: " + col.name);

                // ... ativa a fumaça
                if (fumaca != null)
                {
                    fumaca.Play();

                    // para a fumaça depois de 2 segundos
                    Invoke("PararFumaca", 2f);
                }

                ControleMinigamePocao.ultimoIngredienteJogado_1 = true; //primeiro ingrediente já foi jogado


                //VERIFICAÇÃO DE INGREDIENTES E ORDEM CORRETOS
                if (col.name == "Ingrediente4 (certo)") // ... e se o nome do ingrediente colidido for o ingrediente 4...
                {
                    primeiroIngredienteCerto = true; //... então o primeiro ingrediente necessário para a poção será misturado.
                    Debug.Log("Primeiro ingrediente certo colocado");
                }

                ingredienteDestruído = true; //... e diz à variável que o ingrediente jogado foi destruído
            }
            else if (ControleMinigamePocao.ultimoIngredienteJogado_1 == true)
            {
                ControleMinigamePocao.ultimoIngredienteJogado_1 = false;
                ControleMinigamePocao.ultimoIngredienteJogado_2 = true;

                if (col.name == "Ingrediente6 (certo)") // ... e se o primeiro ingrediente já estiver na mistura e o nome do ingrediente colidido for o ingrediente 6...
                {
                    segundoIngredienteCerto = true; //... então o segundo ingrediente necessário para a poção será misturado.  
                    Debug.Log("Segundo ingrediente certo colocado");
                }

                if (fumaca != null)
                {
                    fumaca.Play();

                    // para a fumaça depois de 2 segundos
                    Invoke("PararFumaca", 2f);
                }
            }
            else if (ControleMinigamePocao.ultimoIngredienteJogado_2 == true)
            {
                ControleMinigamePocao.ultimoIngredienteJogado_2 = false;
                ControleMinigamePocao.ultimoIngredienteJogado_3 = true;

                if (segundoIngredienteCerto == true && segundoIngredienteCerto == true && col.name == "Ingrediente7 (certo)") //... e se o segundo ingrediente já estiver na mistura e o nome do ingrediente colidido for o ingrediente 8...
                {
                    terceiroIngredienteCerto = true; //... então o terceiro ingrediente necessário para a poção será misturado.
                    Debug.Log("Terceiro ingrediente certo colocado");
                }

                if (fumaca != null)
                {
                    fumaca.Play();

                    // para a fumaça depois de 2 segundos
                    Invoke("PararFumaca", 2f);
                }
            }

            gameController.GetComponent<ControleMinigamePocao>().VerificaçãoLimiteIngredientes ();
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