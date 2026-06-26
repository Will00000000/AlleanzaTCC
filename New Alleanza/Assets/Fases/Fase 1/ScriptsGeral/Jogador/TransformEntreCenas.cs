using UnityEngine;

public class TransformEntreCenas: MonoBehaviour
{
    [SerializeField]
    GameObject sceneController;

    SceneController sController;

    private void Start () //no primeiro frame e depois do Awake()
    {
        sceneController = GameObject.Find("SceneController");
        sController = sceneController.GetComponent<SceneController>();

        IsPraia();
    }

    private void IsPraia ()
    {
        if (sController.is_Praia)
        {
            if (sController.was_QuartoMorgan)
            {
                Debug.Log("Jogador está na praia e estava no quarto");
                transform.position = new Vector2(-20, transform.position.y);
            }

            if (sController.was_Praia2)
            {
                Debug.Log("Jogador está na praia e estava na praia2");
                transform.position = new Vector2(-30f, transform.position.y);
            }
        }
    }
}