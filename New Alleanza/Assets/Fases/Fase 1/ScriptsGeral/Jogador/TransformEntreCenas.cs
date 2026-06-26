using UnityEngine;

public class TransformEntreCenas: MonoBehaviour
{
    [SerializeField] GameObject sceneController;
    [SerializeField] GameObject jogador;

    private void Awake () 
    {
        sceneController = GameObject.Find("SceneController");
        jogador = GameObject.Find("Jogador");
    }

    private void Update ()
    {
        SceneController sController = sceneController.GetComponent<SceneController>();
        Rigidbody2D rig = jogador.GetComponent<Rigidbody2D>();

        if (sController.is_Praia)
        {
            if (sController.was_QuartoMorgan)
            {
                Debug.Log("Jogador está na praia e estava no quarto");
                rig.position = new Vector2(-20.5f, 0.51f);
            }

            if (sController.was_Praia2)
            {
                Debug.Log("Jogador está na praia e estava na praia2");
                rig.position = new Vector2(-30f, 0.5f);
            }
        }
    }
}