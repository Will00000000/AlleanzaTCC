using UnityEngine;
using UnityEngine.UI;

public class Coleta : MonoBehaviour
{
    public Sprite spriteItem;

    public Image[] sprite_itensGeral; // Lista que recebe todos os sprites dos itens
    public GameObject[] itensGeral;            // Lista que recebe todos os GameObjects de itens

    // Variáveis estáticas salvam o estado na memória enquanto o jogo estiver aberto.
    // Elas persistem entre trocas de cenas, mas resetam quando o jogo é fechado e reaberto.
    public static bool pecaFoiColetada = false;
    public static bool chaveFoiColetada = false;

    public void ColetarPeca()
    {
        PlayerPrefs.SetInt("Coletou peça", 1);

        itensGeral[0].transform.localScale = new Vector3 (0, 0, 0); // faz a peça sumir
        spriteItem = sprite_itensGeral[0].sprite; // pega o sprite da variável que pertence à chave
    }

    public void ColetarPoema()
    {
        itensGeral[2].GetComponent<RectTransform>().localScale = Vector3.zero; //faz o objeto sumir

        ColetarGenerico(2); //pega o sprite do poema na lista de itens do jogo e joga para a variável de último item coletado
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