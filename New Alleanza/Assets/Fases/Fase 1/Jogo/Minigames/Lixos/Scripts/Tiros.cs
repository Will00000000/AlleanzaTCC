using UnityEngine;

public class Tiros : MonoBehaviour
{  
    Rigidbody2D rig;
    public float velocidade;

    public Transform lixo;

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update ()
    {
        transform.position = new Vector2 (transform.position.x + velocidade * Time.deltaTime, transform.position.y);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "lixo" || col.gameObject.tag == "limite")
        {
            Destroy (gameObject);
        }
    }
}