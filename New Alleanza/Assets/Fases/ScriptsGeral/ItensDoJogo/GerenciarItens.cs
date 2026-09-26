using UnityEngine;

public class GerenciarItens : MonoBehaviour
{
    public GameObject poema;

    private void Start()
    {
        if (PlayerPrefs.GetInt ("was_QuebraCabeça", 0) == 1)
        {
            poema.SetActive(true);
        }
        else
        {
            poema.SetActive(false);
        }
    }
}