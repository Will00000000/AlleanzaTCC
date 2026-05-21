using UnityEngine;
using UnityEngine.UI;

public class Coleta : MonoBehaviour
{
    public Sprite spriteItem;

    public SpriteRenderer[] sprite_itensGeral; //lista que recebe todos os sprites dos itens do jogo (uma biblioteca)
    public GameObject[] itensGeral; //lista que recebe todos os gameObjects de itens do jogo (biblioteca)

    public void ColetarChave ()
    {
        itensGeral[0].transform.localScale = new Vector3 (0, 0, 0); //objeto dhave é desabilitado

        spriteItem = sprite_itensGeral[0].sprite; //pega o sprite 1 "chave"
    }
}