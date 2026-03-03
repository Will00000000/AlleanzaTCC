using UnityEngine;

public class Lixos : MonoBehaviour
{
    Rigidbody2D rig;

    GameObject alvo;
    public float velocidade;

    void Start()
    {
        rig = GetComponent <Rigidbody2D> ();
        alvo = GameObject.FindWithTag ("jogador");
    }

    void Update()
    {
        transform.position = new Vector2 (transform.position.x - velocidade, transform.position.y);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "projetil")
        {
            Destroy(gameObject);
        }
    }
}