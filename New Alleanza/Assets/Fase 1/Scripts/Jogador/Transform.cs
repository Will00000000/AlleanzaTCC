using UnityEngine;

public class Transform_Player : Singleton <Transform_Player>
{
    private void Start () 
    {
        Inicia_Cena();
    }

    void Inicia_Cena ()
    {
        Debug.Log(SceneController.Instance.is_Museu);

        if (SceneController.Instance.is_Museu && SceneController.Instance.was_Rua)
        {
            Jogador2D_Terra.Instance.transform.position = new Vector2(17, transform.position.y);
            Debug.Log("Está no museu e estava na rua");
        }

        if (SceneController.Instance.is_Rua == true && SceneController.Instance.was_Museu == true)
        {
            transform.position = new Vector2(100, 0);
        }
    }
}