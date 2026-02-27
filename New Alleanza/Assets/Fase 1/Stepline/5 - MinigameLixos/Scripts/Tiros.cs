using UnityEngine;

public class Tiros : MonoBehaviour
{  
    Rigidbody2D rig;
    [Range (0, 10)] public float velocidade;

    public Transform lixo;

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update ()
    {
        transform.position = new Vector2 (transform.position.x + velocidade, transform.position.y);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "lixo")
        {
            Destroy (gameObject);
        }
    }
}