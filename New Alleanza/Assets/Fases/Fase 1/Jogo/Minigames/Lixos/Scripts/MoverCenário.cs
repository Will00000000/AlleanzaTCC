using UnityEngine;

public class MoverCenário : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector2(transform.position.x - 1 * Time.deltaTime, transform.position.y);
    }
}
