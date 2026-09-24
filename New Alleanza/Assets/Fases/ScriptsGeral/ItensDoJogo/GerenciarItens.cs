using UnityEngine;

public class GerenciarItens : MonoBehaviour
{
    public GameObject poema;

    private void Start()
    {
        if (PlayerPrefs.GetInt ("was_QuebraCabeça", 0) == 0)
        {
            poema.SetActive(false);
        }
        else
        {
            poema.SetActive(true);
        }
    }
}