using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class CutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;      
    public string cenaDoJogo = "Jogo";   

    void Start()
    {
        videoPlayer.loopPointReached += QuandoVideoAcabar;
    }

    void QuandoVideoAcabar(VideoPlayer vp)
    {
        SceneManager.LoadScene(cenaDoJogo);
    }

   
    public void AvancarUmSegundo()
    {
        if (videoPlayer != null && videoPlayer.isPlaying)
        {
           
            double novoTempo = videoPlayer.time + 2.0;

           
            if (novoTempo < videoPlayer.length)
            {
                videoPlayer.time = novoTempo;
            }
            else
            {
               
                SceneManager.LoadScene(cenaDoJogo);
            }
        }
    }
}