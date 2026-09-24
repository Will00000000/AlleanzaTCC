using UnityEngine;

public class ExpandirItens : MonoBehaviour
{
    public GameObject poema;

    public void FecharPoema ()
    {
        poema.SetActive(false);
    }
}