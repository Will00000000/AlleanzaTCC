using UnityEngine;

public class SelecionarIngrediente : MonoBehaviour
{
    public GameObject[] ingredientes;
    public GameObject contornoDeSeleção;

    public bool ingredienteSelecionado; //se existe algum item selecionado no momento

    int índiceLista;

    private void Update()
    {
        SeleçaoIngrediente();
        ArrastarIngrediente();
        ContornoIngrediente();
    }

    void SeleçaoIngrediente ()
    {
        if (ingredienteSelecionado == false && Input.GetKeyDown(KeyCode.RightArrow)) //se não houver nenhum item selecionado e o jogador apertar a seta para a direita...
        {
            índiceLista += 1; //... o foco vai para o próximo ingrediente da lista.

            if (índiceLista > ingredientes.Length - 1) //se o índice atribuído passar do tamanho da lista...
            {
                índiceLista = 0; //... ele volta para o começo
            }
        }

        if (Caldeirao.ingredienteDestruído == true)
        {
            índiceLista = 0;
            Caldeirao.ingredienteDestruído = false;
        }
    }

    void ContornoIngrediente ()
    {
        if (Caldeirao.ingredienteDestruído == false) // se a variável com o ingrediente atual estiver atribuída...
        {
            contornoDeSeleção.transform.position = new Vector2(ingredientes[índiceLista].transform.position.x, ingredientes[índiceLista].transform.position.y); //o contorno de seleção segue o item em foco

            contornoDeSeleção.GetComponent<SpriteRenderer>().sprite = ingredientes[índiceLista].GetComponent<SpriteRenderer>().sprite; // o contorno se apropria do sprite do item em foco
            contornoDeSeleção.transform.localScale = ingredientes[índiceLista].transform.localScale * 1.2f; //... o contorno aumenta de escala em 1.2 vezes
        }
        else //se a variável com o ingrediente atual ficar vazio, ou seja, suma...
        {
            for (int indice = 0; indice < ingredientes.Length; indice++) //... o código faz uma verificação item por item da lista de ingredientes
            {
                if (ingredientes[indice] != null)
                {
                    contornoDeSeleção.transform.position = new Vector2(ingredientes[indice].transform.position.x, ingredientes[indice].transform.position.y); //... e o primeiro ingrediente disponível recebe o foco

                    contornoDeSeleção.GetComponent<SpriteRenderer>().sprite = ingredientes[indice].GetComponent<SpriteRenderer>().sprite; //... o primeiro ingrediente disponível dá o próprio sprite para o contorno
                    contornoDeSeleção.transform.localScale = ingredientes[indice].transform.localScale * 1.2f; //... o primeiro ingrediente disponível dá um tamanho a mais para o contorno
                }
            }

            Caldeirao.ingredienteDestruído = false;
        }
    }

    void ArrastarIngrediente ()
    {
        if (Input.GetKeyDown(KeyCode.Return) && ingredienteSelecionado == false) // se o jogador apertar Enter...
        {
            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = true; // ... o jogador consegue mover o ingrediente
            ingredienteSelecionado = true; // ...agora é possível o jogar o ingrediente
        }
        else
        {
            JogarIngrediente();
        }
    }

    void JogarIngrediente ()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = false; //... o jogador não consegue mais mover o ingrediente
            ingredienteSelecionado = false; // ... não há mais nenhum ingrediente selecionada
        }
    }
}