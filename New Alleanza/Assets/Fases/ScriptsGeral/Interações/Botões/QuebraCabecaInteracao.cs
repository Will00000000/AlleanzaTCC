using UnityEngine;

public class QuebraCabecaInteracao : MonoBehaviour
{
    public GameObject peça;

    public void AtivarPeca ()
    {
        peça.SetActive (true);
    }
}