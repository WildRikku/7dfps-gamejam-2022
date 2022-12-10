using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
    [Header("Button Sounds")]
    public AudioClip click_sound;
    public AudioClip hover_sound;
    private bool playAudio;

    [Header("Button settings")]
    public Color buttonHoverColor;
    public int buttonTextHoverSize;

    private AsyncOperation asyncLoad;


    void Start()
    {
        playAudio = false;
        //source = this.GetComponent<AudioSource>();

        StartCoroutine(LoadYourAsyncScene());
    }


    IEnumerator LoadYourAsyncScene()
    {
        asyncLoad = SceneManager.LoadSceneAsync("StartScene");
        asyncLoad.allowSceneActivation = false;

        // yield to other processes until the scene is loaded
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }


    //Löst den Szenenwechsel zur Spielszene aus
    public void GoToGameScene()
    {
        if (playAudio == false)
        {
            playAudio = true;
            asyncLoad.allowSceneActivation = true;
        }
    }

    //Löst den Szenenwechsel zu Credits aus
    public void GoToCredits()
    {
        if (playAudio == false)
        {
            playAudio = true;
            SceneManager.LoadScene("CreditScene");
            Debug.Log("HALLO");
        }
    }

    //Löst den Szenenwechsel zur Beendet das Spiel
    public void Quit()
    {
        if (playAudio == false)
        {
            playAudio = true;
            Application.Quit();
        }
    }

    //Beendet das Spiel
    public void GoBackToMenu()
    {
        if (playAudio == false)
        {
            playAudio = true;
            SceneManager.LoadScene("MenuScene");
        }
    }
}
