using UnityEngine;

public class Ingrediente : MonoBehaviour
{
    private Camera mainCamera;
    private Rigidbody2D rb;
    private bool isDragging = false;
    private Vector3 targetPosition;
    private float zDistance;

    void Start()
    {
        mainCamera = Camera.main;
        rb = GetComponent<Rigidbody2D>();
    }

    void OnMouseDown()
    {
        isDragging = true;
        zDistance = mainCamera.WorldToScreenPoint(transform.position).z;
    }

    void OnMouseUp()
    {
        isDragging = false;
    }

    void Update()
    {
        if (isDragging)
        {
            Vector3 mouseScreenPos = Input.mousePosition;
            mouseScreenPos.z = zDistance;
            targetPosition = mainCamera.ScreenToWorldPoint(mouseScreenPos);
        }
    }

    void FixedUpdate()
    {
        if (isDragging)
        {
            rb.MovePosition(targetPosition);
        }
    }
}