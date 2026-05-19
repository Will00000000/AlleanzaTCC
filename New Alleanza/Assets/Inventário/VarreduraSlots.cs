using UnityEngine;
using UnityEngine.UI;

public class VarreduraSlots : MonoBehaviour
{
    public Image [] slot;
    Sprite novoSprite;

    private void Start()
    {

    }

    private void Update()
    {
        if (slot[0].sprite == null)
        {
            Debug.Log("slot 1 livre");
        }
        else if (slot[1].sprite == null)
        {
            Debug.Log("slot 2 livre");
        }
        else if (slot[2].sprite == null)
        {
            Debug.Log("slot 3 livre");
        }
        else if (slot[3].sprite == null)
        {
            Debug.Log("slot 4 livre");
        }
        else if (slot[4].sprite == null)
        {
            Debug.Log("slot 5 livre");
        }
        else if (slot[5].sprite == null)
        {
            Debug.Log("slot 6 livre");
        }
        else if (slot[6].sprite == null)
        {
            Debug.Log("slot 7 livre");
        }
        else if (slot[7].sprite == null)
        {
            Debug.Log("slot 8 livre");
        }
        else if (slot[8].sprite == null)
        {
            Debug.Log("slot 9 livre");
        }
    }
}