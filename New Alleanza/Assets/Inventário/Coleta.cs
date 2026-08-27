using UnityEngine;
using UnityEngine.UI;

public class Coleta : MonoBehaviour
{
    public Sprite spriteItem;

    public SpriteRenderer[] sprite_itensGeral; // Lista que recebe todos os sprites dos itens
    public GameObject[] itensGeral;            // Lista que recebe todos os GameObjects de itens

    // Variáveis estáticas salvam o estado na memória enquanto o jogo estiver aberto.
    // Elas persistem entre trocas de cenas, mas resetam quando o jogo é fechado e reaberto.
    public static bool pecaFoiColetada = false;
    public static bool chaveFoiColetada = false;

    private void Start()
    {
        // Se a peça já foi coletada nesta sessão de jogo, mantém desativada ao carregar a cena
        if (pecaFoiColetada)
        {
            if (itensGeral != null && itensGeral.Length > 0 && itensGeral[0] != null)
            {
                itensGeral[0].SetActive(false);
            }
        }

        // Se a chave já foi coletada nesta sessão de jogo
        if (chaveFoiColetada)
        {
            if (itensGeral != null && itensGeral.Length > 0 && itensGeral[0] != null)
            {
                itensGeral[0].SetActive(false);
            }
        }
    }

    public void ColetarPeca()
    {
        if (itensGeral != null && itensGeral.Length > 0 && itensGeral[0] != null)
        {
            itensGeral[0].SetActive(false); // Desativa o objeto da peça
            pecaFoiColetada = true;         // Marca como coletada apenas na memória atual
        }
    }

    public void ColetarChave()
    {
        ColetarGenerico(0);
        chaveFoiColetada = true;
    }

    public void ColetarItem3()
    {
        ColetarGenerico(2);
    }

    public void ColetarItem4()
    {
        ColetarGenerico(3);
    }

    public void ColetarItem5()
    {
        ColetarGenerico(4);
    }

    public void ColetarItem6()
    {
        ColetarGenerico(5);
    }

    public void ColetarItem7()
    {
        ColetarGenerico(6);
    }

    public void ColetarItem8()
    {
        ColetarGenerico(7);
    }

    public void ColetarItem9()
    {
        ColetarGenerico(8);
    }

    // Função auxiliar para desativar objetos e atribuir o sprite sem repetir código
    private void ColetarGenerico(int indice)
    {
        if (itensGeral != null && itensGeral.Length > indice && itensGeral[indice] != null)
        {
            itensGeral[indice].SetActive(false);
        }

        if (sprite_itensGeral != null && sprite_itensGeral.Length > indice && sprite_itensGeral[indice] != null)
        {
            spriteItem = sprite_itensGeral[indice].sprite;
        }
    }
}