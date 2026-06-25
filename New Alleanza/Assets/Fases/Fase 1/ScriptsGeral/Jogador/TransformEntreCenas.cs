using UnityEngine;

public class TransformEntreCenas: MonoBehaviour
{
    GameObject sceneController;
    GameObject jogador;

    private void Start () 
    {
        sceneController = GameObject.Find("SceneController");
        jogador = GameObject.Find("Jogador");
    }

    private void Update()
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
            }

            if (sceneController.GetComponent <SceneController>().was_Escadaria)
            {
                jogador.transform.position = new Vector2 (-3.28999996f, -1.7460000f);
            }
        }
    }
}