using UnityEngine;

public class MoverIngrediente : MonoBehaviour
{
    Rigidbody2D rig;
    public int velocidade;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw ("Horizontal") * velocidade, Input.GetAxisRaw ("Vertical") * velocidade);
    }
}