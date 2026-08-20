using UnityEngine;

public class Lixos : MonoBehaviour
{
    public float velocidade;
    Rigidbody2D rig;

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update()
    {
        transform.position = new Vector2 (transform.position.x - velocidade * Time.deltaTime, transform.position.y);
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "projetil")
        {
            Destroy(gameObject);
            ControllerLixos.pontuação += 1;
        }

        if (col.gameObject.tag == "limite")
        {
            Destroy (gameObject);
        }
    }
}