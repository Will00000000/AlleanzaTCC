using UnityEngine;

public class InteraçãoCidade : MonoBehaviour
{
    public GameObject GoCasaHelena;

    void Update()
    {
        InteraçãoEntreCenas();
    }

    private void InteraçãoEntreCenas ()
    {
        if (PlayerPrefs.GetInt ("Visitou o castelo", 0) == 1)
        {
            GoCasaHelena.SetActive (true);
        }
        else
        {
            GoCasaHelena.SetActive (false);
        }
    }
}