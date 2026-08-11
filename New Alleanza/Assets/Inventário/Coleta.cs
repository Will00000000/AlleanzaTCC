using UnityEngine;

public class Coleta : MonoBehaviour
{
    public Sprite spriteItem;

    public SpriteRenderer[] sprite_itensGeral; //lista que recebe todos os sprites dos itens do jogo (uma biblioteca)
    public GameObject[] itensGeral; //lista que recebe todos os gameObjects de itens do jogo (biblioteca)


    public void ColetarChave ()
    {
        itensGeral[0].transform.localScale = new Vector3 (0, 0, 0); //objeto chave é desabilitado
        spriteItem = sprite_itensGeral[0].sprite; //pega o sprite 1 "chave"
    }

    public void ColetarPeca()
    {
        itensGeral[1].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[1].sprite; //pega o sprite 1 "chave"
    }

    public void ColetarItem3()
    {
        itensGeral[2].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[2].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem4()
    {
        itensGeral[3].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[3].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem5()
    {
        itensGeral[4].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[4].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem6()
    {
        itensGeral[5].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[5].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem7()
    {
        itensGeral[6].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[6].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem8()
    {
        itensGeral[7].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[7].sprite; //pega o sprite 1 "chave"
    }
    public void ColetarItem9()
    {
        itensGeral[8].transform.localScale = new Vector3(0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[8].sprite; //pega o sprite 1 "chave"
    }
}