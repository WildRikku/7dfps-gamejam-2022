using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider musicSlider;

    public const string MIXER_MUSIC = "MasterVolume";



    void Awake()
    {
        
        musicSlider.onValueChanged.AddListener(SetMusicVolume);
    }

    void Start()
    {
        //load volume value from PlayerPrefs
        musicSlider.value = PlayerPrefs.GetFloat(AudioManager.MUSIC_KEY, 1f);
    }
    void OnDisable()
    {
        //save value in PlayerPrefs
        PlayerPrefs.SetFloat(AudioManager.MUSIC_KEY, musicSlider.value);
    }

    void SetMusicVolume(float value)
    {
        //set mixer Volume
        mixer.SetFloat(MIXER_MUSIC, Mathf.Log10(value) *20);
    }

}
