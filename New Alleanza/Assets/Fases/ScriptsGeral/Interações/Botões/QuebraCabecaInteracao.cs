using UnityEngine;

public class QuebraCabecaInteracao : MonoBehaviour
{
    public RectTransform peça;

    public void AtivarPeca ()
    {
        peça.localScale = new Vector2 (0.35f, 0.35f);
    }

    public void PegarPoema 
}