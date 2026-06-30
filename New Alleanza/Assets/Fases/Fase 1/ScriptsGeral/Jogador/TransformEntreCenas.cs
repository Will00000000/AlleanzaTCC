using UnityEngine;

public class TransformEntreCenas: MonoBehaviour
{
    private void Start () //no primeiro frame e depois do Awake()
    {
        IsQuartoMorgan();
        IsPraia();
    }
    private void IsQuartoMorgan()
    {
        if (PlayerPrefs.GetInt("is_QuartoMorgan", 0) == 1) //se o jogador estiver no quarto do morgan...
        {
            if (PlayerPrefs.GetInt("was_Praia", 0) == 1)// e estava na praia...
            {
                Debug.Log("Jogador está na praia e estava no quarto");
                transform.position = new Vector2(-3, transform.position.y); // posição no quarto vai para a porta

                PlayerPrefs.Save();
            }
        }
        else
        {
            PlayerPrefs.DeleteKey("is_QuartoMorgan");
            PlayerPrefs.DeleteKey("was_Praia");
        }
    }

    private void IsPraia ()
    {
        if (PlayerPrefs.GetInt ("is_Praia", 0) == 1)
        {
            if (PlayerPrefs.GetInt ("was_QuartoMorgan", 0) == 1)
            {
                Debug.Log("Jogador está na praia e estava no quarto");
                transform.position = new Vector2(-20, transform.position.y);
            }

            if (PlayerPrefs.GetInt("was_Praia2", 0) == 1)
            {
                Debug.Log("Jogador está na praia e estava na praia2");
                transform.position = new Vector2(-30f, transform.position.y);
            }
        }
        else
        {
            PlayerPrefs.DeleteKey("is_Praia");
            PlayerPrefs.DeleteKey("was_QuartoMorgan");
            PlayerPrefs.DeleteKey("was_Praia2");
        }
    }
}