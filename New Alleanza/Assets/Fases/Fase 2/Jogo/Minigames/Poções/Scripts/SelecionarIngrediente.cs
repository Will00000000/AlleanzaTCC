using UnityEngine;

public class SelecionarIngrediente : MonoBehaviour
{
    public Transform[] ingredientes;
    public GameObject contornoDeSeleção;

    bool ingredienteSelecionado; //se existe algum item selecionado no momento

    int índiceLista;

    private void Update()
    {
        SeleçaoIngrediente();
        MoverIngrediente();
    }

    void SeleçaoIngrediente ()
    {
        contornoDeSeleção.transform.position = new Vector2(ingredientes[índiceLista].transform.position.x, ingredientes[índiceLista].transform.position.y); //o contorno de seleção segue o item em foco

        if (ingredienteSelecionado == false && Input.GetKeyDown(KeyCode.RightArrow)) //se não houver nenhum item selecionado e o jogador apertar a seta para a direita...
        {
            índiceLista += 1; //... o foco vai para o próximo ingrediente da lista.

            if (índiceLista > ingredientes.Length - 1) //se o índice atribuído passar do tamanho da lista...
            {
                índiceLista = 0; //... ele volta para o começo
            }
        }
    }

    void MoverIngrediente ()
    {
        if (Input.GetKeyDown(KeyCode.Return)) // se o jogador apertar Enter...
        {
            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = true; // ... o jogador consegue mover o ingrediente

            ingredienteSelecionado = true; // ...agora é possível o jogar o ingrediente
        }

        if (Input.GetKeyDown(KeyCode.Return) && ingredienteSelecionado == true) // se o jogador apertar Enter e há um ingrediente selecionado
        {
            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = false; //... o jogador não consegue mais mover o ingrediente

            ingredienteSelecionado = false; // ... não há mais nenhum ingrediente selecionada
        }
    }
}