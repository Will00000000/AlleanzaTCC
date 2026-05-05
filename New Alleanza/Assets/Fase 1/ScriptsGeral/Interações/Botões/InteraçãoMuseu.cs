using UnityEngine;

public class InteraçãoMuseu : MonoBehaviour
{
    GameObject quebraCabeca;

    void Start ()
    {
        quebraCabeca = GameObject.Find ("CanvasQuebraCabeca");
    }

    public void AbrirQuebraCabeca ()
    {
        quebraCabeca.SetActive (true);
    }

    public void FecharQuebraCabeca ()
    {
        quebraCabeca.SetActive (false);
    }
}