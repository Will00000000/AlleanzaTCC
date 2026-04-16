using UnityEngine;

public class Instantiation_Player : MonoBehaviour
{
    public Transform initialPoint;

    void InstantiatePlayer ()
    {
        Instantiate (gameObject, initialPoint.position, initialPoint.rotation);
    }
}