using UnityEngine;

public class Tiros : MonoBehaviour
{  
    public float velocidade; //velocidade do tiro

    void Update ()
    {
        transform.position = new Vector2 (transform.position.x + velocidade * Time.deltaTime, transform.position.y); //movimento do tiro
    }

    void OnTriggerEnter2D (Collider2D col) //no contato Trigger do colisor
    {
        if (col.gameObject.tag == "lixo" || col.gameObject.tag == "limite") //se o projétil contatar um objeto com a tag "lixo" ou "limite"...
        {
            Destroy (gameObject); //...ele é destruído
        }
    }
}