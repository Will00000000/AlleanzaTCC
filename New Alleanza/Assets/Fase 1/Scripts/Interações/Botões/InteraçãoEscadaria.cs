using UnityEngine;

public class InteraçãoEscadaria : MonoBehaviour
{
    public GameObject placa;

    public void AbrirPlaca ()
    {
        placa.SetActive (true);
    }

    public void FecharPlaca ()
    {
        placa.SetActive (false);
    }
}