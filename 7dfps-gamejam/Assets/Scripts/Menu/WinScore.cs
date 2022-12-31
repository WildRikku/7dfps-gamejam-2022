using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScore : MonoBehaviour
{
    public Text currentTriesText;
    private int currentTriesValue;

    public Text highscoreText;
    private int highscoreValue;
    public string highScoreString;

    void Awake()
    {
        currentTriesValue = PlayerPrefs.GetInt("DcSaveTemp", 0);
        highscoreValue = PlayerPrefs.GetInt("DcSave", 0);
    }

    void Start()
    {
        currentTriesText.text = currentTriesValue.ToString();

        if (currentTriesValue > 0)
        {
            if (highscoreValue == 0) //first run
            {
                highscoreText.text = highScoreString;
                PlayerPrefs.SetInt("DcSave", highscoreValue);
            }
            else if (currentTriesValue < highscoreValue)
            { 
                highscoreText.text = highScoreString;
                PlayerPrefs.SetInt("DcSave", highscoreValue);
            }
        }
    }

}
