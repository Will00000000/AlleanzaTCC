using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarraProgresso : MonoBehaviour
{
    public Slider barraDeProgresso;
    public TMP_Text contagemLixos;

    void Update()
    {
        barraDeProgresso.value = ControllerLixos.pontuação / 100;
        contagemLixos.text = $"{ControllerLixos.pontuação}/100";
    }
}