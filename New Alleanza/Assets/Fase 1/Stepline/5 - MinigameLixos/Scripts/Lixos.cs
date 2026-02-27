using UnityEngine;

public class Lixos : MonoBehaviour
{
    Rigidbody2D rig;

    public Transform alvo;
    public int velocidade;

    void Start()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards (transform.position, alvo.position, velocidade * Time.deltaTime);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "projetil")
        {
            Destroy(gameObject);
        }
    }
}