using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;      // arraste o VideoPlayer aqui no inspector
    public string cenaDoJogo = "Jogo";   // nome da cena do jogo

    void Start()
    {
        videoPlayer.loopPointReached += QuandoVideoAcabar;
    }

    void QuandoVideoAcabar(VideoPlayer vp)
    {
        SceneManager.LoadScene(cenaDoJogo);
    }
}
