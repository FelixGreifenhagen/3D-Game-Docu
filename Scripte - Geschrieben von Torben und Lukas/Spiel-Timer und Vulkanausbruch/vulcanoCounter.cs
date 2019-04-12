using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class vulcanoCounter : MonoBehaviour
{
    public static float counter;
    public Text vulcanotext;
    public static string vulcanoSekunden;
    public static string vulcanoMinuten;
    float counterMinutes;
    float counterSeconds;
    void Start()
    {
        counter = 1800.0f;
    }
    void Update()
    {        
        counter -= Time.deltaTime;
        counterMinutes = counter / 60;
        counterSeconds = counter % 60;
        if(counterSeconds < 10)
        {
            vulcanoSekunden = "0" + ((int)counterSeconds).ToString();
        }   
        else
        {
            vulcanoSekunden = ((int)counterSeconds).ToString();
        }
        if(counterMinutes < 10)
        {
            vulcanoMinuten = "0" + ((int)counterMinutes).ToString();
        }
        else
        {
            vulcanoMinuten = ((int)counterMinutes).ToString();
        }        
        vulcanotext.text = vulcanoMinuten + ":" + vulcanoSekunden;
        if(counter < 1)
        {
            SceneManager.LoadScene("Vulkan");
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
}
