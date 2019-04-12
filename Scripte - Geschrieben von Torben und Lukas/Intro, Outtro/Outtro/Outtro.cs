using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Outtro : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float timer;
    public string restZeitMin;
    public string restZeitSec;
    public string restZeit;
    public Text restText;
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
        timer = 0;
    }
    void Update()
    {
        restZeitMin = vulcanoCounter.vulcanoMinuten;
        restZeitSec = vulcanoCounter.vulcanoSekunden;
        restZeit = "Du hattest noch " + restZeitMin + ":" + restZeitSec + " um dich vor dem Vulkanausbruch zu retten!";
        restText.text = restZeit;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        timer += Time.deltaTime;
        if(timer > 20)
        {
            if (canvasGroup.alpha < 1)
            {
                canvasGroup.alpha += Time.deltaTime / 6;
                print(canvasGroup.alpha);
            }
            if(timer > 30)
            {
                SceneManager.LoadScene("MainMenu");
            }
        }        
    }    
}
