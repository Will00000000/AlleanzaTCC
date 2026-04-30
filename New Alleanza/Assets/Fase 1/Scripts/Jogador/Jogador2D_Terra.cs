using UnityEngine;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;
    private Camera visaoAtaque;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

    [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    public SceneController sceneController;

    // Start is called before the first frame update
    void Start()
    {
        if (sceneController.is_QuartoMorgan)
        {
            Debug.Log("Você entrou na Casa");

            if (sceneController.was_Praia)
            {
                transform.position = new Vector2 (-3.4f, -1.9f);

                Debug.Log("Você estava na Praia e entrou na Casa");
            }
        }

        if (sceneController.is_Praia)
        {
            if (sceneController.was_QuartoMorgan)
            {
                transform.position = new Vector2(1.2f, 0.5f);
            }

            if (sceneController.was_Escadaria)
            {
                transform.position = new Vector2(-34, -1.9f);
            }
        }

        if (sceneController.is_Escadaria)
        {
            if (sceneController.was_Praia)
            {
                transform.position = new Vector2(8.5f, -0.1f);
            }

            if (sceneController.was_Rua)
            {
                transform.position = new Vector2(-2.8f, 0.5f);
            }
        }

        if (sceneController.is_Rua)
        {
            if (sceneController.was_Escadaria)
            {
                transform.position = new Vector2(86, -2.24f);
            }

            if (sceneController.was_Museu)
            {
                transform.position = new Vector2(86, -2.24f);
            }
        }

        if (sceneController.is_Museu)
        {
            if (sceneController.was_Rua)
            {
                transform.position = new Vector2(15.6f, -2.2f);
            }
        }

        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Mover();

        if (DashAtivado)
        {
            DashAtaque();
        }

        anima.SetFloat("SideMove", Mathf.Abs (xMove));
    }

    void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, yMove * velocidade);
        xMove = Input.GetAxisRaw("Horizontal");

        if (xMove < 0)
        {
            transform.eulerAngles = new Vector2(0, 180);
        }
        else
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
    }

    //REPAGINAR ISSO AQUI
    /*void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = true;
            destino = col.transform.position;
            destinoCam = new Vector3(col.transform.position.x, col.transform.position.y, -10);

            CamSeguindo = false;
        }
    

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "area ataque")
        {
            DashAtivado = false;
            CamSeguindo = true;
        }
    }*/

    private void DashAtaque()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}