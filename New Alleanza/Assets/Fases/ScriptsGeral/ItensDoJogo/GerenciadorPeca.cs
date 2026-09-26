using UnityEngine;

public class GerenciadorPeca : MonoBehaviour
{
    public GameObject dialogoPeca; // variável que pga a colisão do diálogo da peça
    public GameObject peca;

    private void Start ()
    {
        if (PlayerPrefs.GetInt ("Coletou peça", 0) == 1)
        {
            peca.SetActive (false);
            dialogoPeca.SetActive (false);
        }
    }
}