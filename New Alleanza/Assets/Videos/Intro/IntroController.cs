using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using System.Collections;

public class IntroController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public string nomeDaProximaCena;

    void Start()
    {
        videoPlayer.playOnAwake = false;
        videoPlayer.waitForFirstFrame = true;
        videoPlayer.targetCameraAlpha = 0f;

        videoPlayer.prepareCompleted += AoTerminarDePreparar;
        videoPlayer.loopPointReached += AoTerminarOVideo;

        videoPlayer.Prepare();
    }

    void AoTerminarDePreparar(VideoPlayer source)
    {
        videoPlayer.Play();
        StartCoroutine(AparecerVideoSuave());
        // O carregamento em segundo plano foi REMOVIDO daqui para não roubar processamento
    }

    IEnumerator AparecerVideoSuave()
    {
        yield return new WaitForEndOfFrame();
        yield return new WaitForEndOfFrame();
        videoPlayer.targetCameraAlpha = 1f;
    }

    void AoTerminarOVideo(VideoPlayer source)
    {
        // O computador foca 100% no vídeo. Só quando ele fecha, o menu é carregado.
        SceneManager.LoadScene(nomeDaProximaCena);
    }
}