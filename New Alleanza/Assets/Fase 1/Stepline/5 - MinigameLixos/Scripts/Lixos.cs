using UnityEngine;

public class Lixos : MonoBehaviour
{
    Rigidbody2D rig;

    GameObject alvo;
    public int velocidade;

    int lixosAcertados = 0;
    bool lixoDestruido = false;

    void Start()
    {
        rig = GetComponent <Rigidbody2D> ();
        alvo = GameObject.FindWithTag ("jogador");
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards (transform.position, alvo.transform.position, velocidade * Time.deltaTime);

        //Pontuacao ();
    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "projetil")
        {
            Destroy(gameObject);
            lixosAcertados += 1;
        }
    }

    /*void Pontuacao ()
    {
        if (lixoDestruido = true)
        {
            lixosAcertados += 1;
            Debug.Log (lixosAcertados);
        }
    }*/
}