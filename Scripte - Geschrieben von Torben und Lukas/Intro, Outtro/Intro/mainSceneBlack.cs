using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainSceneBlack : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float timer;
    public GameObject startText;
    void Start()
    {
        startText.SetActive(true);
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 1;
    }
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 13)
        {
            startText.SetActive(false);
            if (canvasGroup.alpha > 0)
            {
                canvasGroup.alpha -= Time.deltaTime / 10;
            }            
        }
    }
}
