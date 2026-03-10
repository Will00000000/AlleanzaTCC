using UnityEngine;

public class Arrastavel : MonoBehaviour
{
    private Vector3 offset;
    private bool arrastando = false;

    void OnMouseDown()
    {
        offset = transform.position - GetMouseWorldPosition();
        arrastando = true;
    }

    void OnMouseUp()
    {
        arrastando = false;
    }

    void Update()
    {
        if (arrastando)
        {
            transform.position = GetMouseWorldPosition() + offset;
        }
    }

    Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = 10f;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    
}