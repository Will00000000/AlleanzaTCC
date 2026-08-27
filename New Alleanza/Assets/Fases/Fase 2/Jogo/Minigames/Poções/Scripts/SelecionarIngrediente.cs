using UnityEngine;

public class SelecionarIngrediente : MonoBehaviour
{
    public Transform[] ingredientes;
    public GameObject contornoDeSeleção;

    int índiceLista;

    private void Update()
    {
        SeleçaoIngrediente();
        MoverIngrediente();
    }

    void SeleçaoIngrediente ()
    {
        contornoDeSeleção.transform.position = new Vector2(ingredientes[índiceLista].transform.position.x, ingredientes[índiceLista].transform.position.y); //o contorno de seleção segue o item em foco

        if (Input.GetKeyDown(KeyCode.RightArrow)) //se o jogador apertar a seta para a direita...
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = true;
        }
    }
}