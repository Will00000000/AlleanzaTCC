using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Image [] slots;

    private void Start()
    {
        slots = GetComponentsInChildren<Image> ();
    }
}
