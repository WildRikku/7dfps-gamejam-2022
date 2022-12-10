using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    public Canvas canvas;
    private AudioSource audioSource;
    private ScreenManager screenManager;

    private AudioClip click_sound;
    private AudioClip hover_sound;

    private Text obj_text;
    private int initFontSize;
    private int hoverFontSize;
    private Color initColor;
    private Color hoverColor;

    private bool isClick = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = canvas.GetComponent<AudioSource>();
        
        screenManager = canvas.GetComponent<ScreenManager>();
        hoverColor = screenManager.buttonHoverColor;
        hover_sound = screenManager.hover_sound;
        click_sound = screenManager.click_sound;
        hoverFontSize = screenManager.buttonTextHoverSize;

        obj_text = GetComponentInChildren<Text>();
        initColor = obj_text.color;
        initFontSize = obj_text.fontSize;
    }

    //Mouse enter
    public void OnPointerEnter(PointerEventData eventData)
    {
        obj_text.color = hoverColor;
        obj_text.fontSize = hoverFontSize;
        audioSource.clip = hover_sound;
        audioSource.Play();
    }

    //Mouse leave
    public void OnPointerExit(PointerEventData eventData)
    {
        obj_text.color = initColor;
        obj_text.fontSize = initFontSize;
    }

    //Mouse click
    public void OnPointerDown(PointerEventData eventData)
    {
        if (isClick == false)
        {
            audioSource.PlayOneShot(click_sound);
            isClick = true;
        }
    }

}
