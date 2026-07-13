using UnityEngine;

public class InteraçãoEscadaria : MonoBehaviour
{
    public GameObject placa;
    public GameObject InterfaceGeral;

    public void AbrirPlaca ()
    {
        placa.SetActive (true);
        InterfaceGeral.SetActive (false);
    }

    public void FecharPlaca ()
    {
        placa.SetActive (false);
        InterfaceGeral.SetActive (true);
    }
}