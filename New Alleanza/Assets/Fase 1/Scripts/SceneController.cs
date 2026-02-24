using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public GameObject cam;

    public void GoPraia()
    {
        SceneManager.LoadScene("Praia");
    }

    public void GoCasa()
    {
        SceneManager.LoadScene("MorganHouse");
    }

    public void GoEscadaria()
    {
        SceneManager.LoadScene("Escadaria");
    }
    
    /*void OnColliderEnter2D (Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            cam.transform.position = new Vector3(transform.position.x, transform.position.y + 2, transform.position.z);
        }
    }*/
}