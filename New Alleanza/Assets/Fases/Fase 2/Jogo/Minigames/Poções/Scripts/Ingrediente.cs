using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingrediente : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "chao")
        {
            Derrota();
        }
    }

    void Derrota()
    {
        SceneManager.LoadScene("CenaDerrota");
    }
}