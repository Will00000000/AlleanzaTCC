using UnityEngine;

public class GetSingleton : MonoBehaviour
{
    Canvas canvas; //acessando o componente Canvas

    private void Start()
    {
        Canvas canvas = GetComponent<Canvas>(); 

        
    }
}