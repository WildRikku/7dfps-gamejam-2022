using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class WaveController : MonoBehaviour
{
    public int timerValue = 0;
    public int waveTime = 60;
    private int wave = 1;
    public Text timerText;
    public Text waveText;

    public Color timerInitColor;
    public Color timerEndColor;

    private AudioSource audioSource;
    public AudioClip waveStartSound;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(time());
        waveText.color = timerInitColor;
    }

    IEnumerator time()
    {
        bool loop = true;
        while (loop)
        {
            TimeCount();
            yield return new WaitForSeconds(1);
        }
    }
    
    void TimeCount()
    {
        timerValue ++;

        //change text color
        if (timerValue >= waveTime - 3)
        {
            timerText.color = timerEndColor;
        }
        //new Wave
        if (timerValue >= waveTime +1)
        {
            wave++;
            timerValue = 1;

            timerText.color = timerInitColor;

            waveText.text = "Wave " + wave.ToString();
            audioSource.PlayOneShot(waveStartSound);
        }

        timerText.text = timerValue.ToString();
    }
}
