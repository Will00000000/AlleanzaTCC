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
        MoverIngrediente();
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
    }

    void ContornoIngrediente ()
    {
        contornoDeSeleção.transform.position = new Vector2(ingredientes[índiceLista].transform.position.x, ingredientes[índiceLista].transform.position.y); //o contorno de seleção segue o item em foco

        contornoDeSeleção.GetComponent<SpriteRenderer>().sprite = ingredientes[índiceLista].GetComponent<SpriteRenderer>().sprite;
        contornoDeSeleção.transform.localScale = ingredientes[índiceLista].transform.localScale * 1.2f;
    }

    void MoverIngrediente ()
    {
        if (Input.GetKeyDown(KeyCode.Return) && ingredienteSelecionado == false) // se o jogador apertar Enter...
        {
            Debug.Log("Enter apertado");

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
            Debug.Log("Enter apertado mais uma vez");

            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = false; //... o jogador não consegue mais mover o ingrediente
            ingredienteSelecionado = false; // ... não há mais nenhum ingrediente selecionada
        }
    }
}