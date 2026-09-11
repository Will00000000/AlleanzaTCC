using UnityEngine;

public class Etinos : MonoBehaviour
{
    float cooldown = 7;

    bool ataqueChamas, ataqueOndasSonoras;

    private void Cooldown ()
    {
        cooldown -= Time.deltaTime;

        if (cooldown == 0)
        {
            Ataque();

            cooldown = 7;
        }
    }

    private void Ataque ()
    {
        ataqueChamas = true;


    }

    private void Chamas ()
    {

    }

    private void OndasSonoras ()
    {

    }
}