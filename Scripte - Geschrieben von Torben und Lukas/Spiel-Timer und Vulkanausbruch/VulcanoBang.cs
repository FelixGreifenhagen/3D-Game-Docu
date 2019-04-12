using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VulcanoBang : MonoBehaviour
{
    public CanvasGroup canvasGroup;    
    void Start()
    {  
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0;
    }
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if (canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += Time.deltaTime / 3;
            print(canvasGroup.alpha);
        }
    }   
}
