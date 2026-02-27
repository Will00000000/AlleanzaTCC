using UnityEngine;

public class JogadorOceano : MonoBehaviour
{
    Rigidbody2D rig;

    [Range (0, 10)] public int velocidade;

    Vector2 posicaoMouse;
    float anguloMira;

    public GameObject projetil;
    public Transform disparo;

    void Start ()
    {
        rig = GetComponent <Rigidbody2D> ();
    }

    void Update ()
    {
        Vector2 distancia = posicaoMouse - rig.position;
        posicaoMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);

        Disparar ();
        Mover ();

        Debug.Log (anguloMira);
    }

    void Mover ()
    {
        rig.velocity = new Vector2 (rig.velocity.x, Input.GetAxisRaw ("Vertical") * velocidade);
    }

    private void Disparar ()
    {
        if (Input.GetButtonDown ("Fire1"))
        {
            Instantiate (projetil, disparo.position, disparo.rotation);
        }
    }
}