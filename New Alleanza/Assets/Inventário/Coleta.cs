using UnityEngine;
using UnityEngine.UI;

public class Coleta : MonoBehaviour
{
    [HideInInspector]
    public Sprite spriteItem;

    public void Coletar ()
    {
        gameObject.SetActive (false);
        spriteItem = gameObject.GetComponent<Image>().sprite;
    }
}