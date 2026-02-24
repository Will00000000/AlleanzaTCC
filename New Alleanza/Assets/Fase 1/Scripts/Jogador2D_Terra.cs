using UnityEngine;
using UnityEngine.SceneManagement;

public class Jogador2D_Terra : MonoBehaviour
{
    private Rigidbody2D rig;
    private Camera visaoAtaque;

    public bool CamSeguindo = true;
    public Vector3 destinoCam;

    string nameScene;

   [Header("Movimento")]
    [SerializeField] int velocidade;
    [SerializeField] float velocidadeDash, pulo;
    [SerializeField] Vector2 destino;
    [SerializeField] Vector2 move;
    [SerializeField] bool DashAtivado = false;

    [Header("Animação")]
    Animator anima;
    float xMove, yMove;

    // Start is called before the first frame update
    void Start()
    {
        anima = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        nameScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        Mover();

        if (DashAtivado)
        {
            Dash();
        }

        anima.SetFloat("SideMove", Mathf.Abs (xMove));
    }

    void Mover()
    {
        rig.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * velocidade, yMove * velocidade);
        xMove = Input.GetAxisRaw("Horizontal");
        
        if (nameScene == "Cidade")
        {
            yMove = Input.GetAxisRaw("Vertical");
        }

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

    void OnColliderEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "ponte")
        {
            
        }
    }

    private void Dash()
    {
        if (Input.GetMouseButtonDown(0))
        {
            destino = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        transform.position = Vector2.MoveTowards(transform.position, destino, velocidadeDash * Time.deltaTime);
    }
}