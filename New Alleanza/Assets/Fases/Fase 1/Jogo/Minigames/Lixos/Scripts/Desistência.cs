using UnityEngine;
using UnityEngine.SceneManagement;

public class Desistência : MonoBehaviour
{
    private void Update ()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D))
        {
            SceneManager.LoadScene ("Atlantis");
        }
    }
}