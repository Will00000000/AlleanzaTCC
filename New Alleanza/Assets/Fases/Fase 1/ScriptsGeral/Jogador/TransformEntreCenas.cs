using UnityEngine;

public class TransformEntreCenas: MonoBehaviour
{
    GameObject sceneController;
    GameObject jogador;

    private void Awake () 
    {
        sceneController = GameObject.Find("SceneController");
        jogador = GameObject.Find("Jogador");
    }

    private void Start ()
    {
        Is_Praia();
    }

    private void Is_Praia ()
    {
        if (sceneController.GetComponent<SceneController>().is_Praia)
        {
            if (sceneController.GetComponent <SceneController>().was_QuartoMorgan)
            {
                jogador.transform.position = new Vector2 (-20.5799999f, 0.519999981f);
                Debug.Log("Jogador está na praia e estava no quarto");
            }

            if (sceneController.GetComponent <SceneController>().was_Praia2)
            {
                jogador.transform.position = new Vector2 (-3.28999996f, -1.7460000f);
                Debug.Log("Jogador está na praia e estava na segunda praia2");
            }
        }
    }
}