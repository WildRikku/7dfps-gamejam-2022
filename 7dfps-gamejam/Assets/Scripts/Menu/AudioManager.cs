using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    [SerializeField] AudioMixer mixer;

    public const string MUSIC_KEY = "MusicVolume";

    void Start()
    {
        if (instance == null)
        {
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        LoadVolume();
    }

    void LoadVolume() //Volume saved in VolumeSettings.cs
    {
        
        float musicVolume = PlayerPrefs.GetFloat(MUSIC_KEY, 0.6f);
        mixer.SetFloat(VolumeSettings.MIXER_MUSIC, Mathf.Log10(musicVolume) * 20);
        //SetVolume(musicVolume);

    }
    /*
    public void SetVolume(float value)
    {
        Debug.Log(value);
        mixer.SetFloat("MasterVolume", Mathf.Log10(value) * 20);
    }*/
}
