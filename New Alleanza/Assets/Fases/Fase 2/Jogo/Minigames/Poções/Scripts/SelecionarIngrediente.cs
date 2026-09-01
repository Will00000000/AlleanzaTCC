using UnityEngine;

public class SelecionarIngrediente : MonoBehaviour
{
    public GameObject[] ingredientes;
    public GameObject contornoDeSeleção;

    public bool ingredienteSelecionado; // Se existe algum item sendo movido no momento

    int índiceLista = 0;

    private void Update()
    {
        ValidarIngredienteAtual();
        SeleçaoIngrediente();
        ArrastarIngrediente();
        ContornoIngrediente();
    }

    // Procura um ingrediente válido caso o atual tenha sido destruído pelo caldeirão
    void ValidarIngredienteAtual()
    {
        // Se o ingrediente atual no índice foi destruído (é null)
        if (ingredientes[índiceLista] == null)
        {
            ingredienteSelecionado = false; // Libera o estado de seleção

            // Procura o primeiro ingrediente da lista que ainda existe
            for (int i = 0; i < ingredientes.Length; i++)
            {
                if (ingredientes[i] != null)
                {
                    índiceLista = i;
                    return;
                }
            }
        }
    }

    void SeleçaoIngrediente()
    {
        // Avança na lista ao pressionar a seta para a direita
        if (!ingredienteSelecionado && Input.GetKeyDown(KeyCode.RightArrow))
        {
            int tentativas = 0;

            // Avança para o próximo ingrediente e pula os que já foram destruídos
            do
            {
                índiceLista++;

                if (índiceLista >= ingredientes.Length)
                {
                    índiceLista = 0; // Volta para o início da lista
                }

                tentativas++;
            }
            while (ingredientes[índiceLista] == null && tentativas < ingredientes.Length);
        }
    }

    void ContornoIngrediente()
    {
        // Se existir um ingrediente válido no índice atual
        if (ingredientes[índiceLista] != null)
        {
            contornoDeSeleção.SetActive(true);

            Transform target = ingredientes[índiceLista].transform;
            SpriteRenderer targetSprite = ingredientes[índiceLista].GetComponent<SpriteRenderer>();

            // Ajusta posição, sprite e escala do contorno
            contornoDeSeleção.transform.position = new Vector2(target.position.x, target.position.y);
            contornoDeSeleção.GetComponent<SpriteRenderer>().sprite = targetSprite.sprite;
            contornoDeSeleção.transform.localScale = target.localScale * 1.2f;
        }
        else
        {
            // Se TODOS os ingredientes forem destruídos, esconde o contorno
            contornoDeSeleção.SetActive(false);
        }
    }

    void ArrastarIngrediente()
    {
        // Se não houver nenhum ingrediente no índice, ignora a tecla
        if (ingredientes[índiceLista] == null) return;

        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (!ingredienteSelecionado)
            {
                // Começa a mover o ingrediente
                ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = true;
                ingredienteSelecionado = true;
            }
            else
            {
                // Solta o ingrediente
                ingredientes[índiceLista].GetComponent<MoverIngrediente>().enabled = false;
                ingredienteSelecionado = false;
            }
        }
    }
}