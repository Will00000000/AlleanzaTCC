using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jogador2D_Mar : MonoBehaviour
{
    Rigidbody2D rig;
    public float velocidade, forcaDash;
    Vector2 mover, dash;
    public  bool darDash = false, NoChão;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update ()
    {
        if (darDash == false)
        {
            rig.velocity = mover * velocidade;
        }
    }

    public void OnMover (InputAction.CallbackContext context)
    {
        if (NoChão == true)
        {
            darDash = false;
            mover = context.ReadValue <Vector2> ();
        }
        else
        {
            mover = new Vector2(0, 0);
        }
    }

    public void OnDash (InputAction.CallbackContext context)
    {
        darDash = true;
        dash = context.ReadValue <Vector2> ();
        rig.AddForce (new Vector2 (dash.x * forcaDash, dash.y * forcaDash), ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D (Collision2D col)
    {  
        if (col.gameObject.tag == "chao")
        {
            NoChão = true;
        }
        else
        {
            NoChão = false;
        }
    }
}