using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalCameraMovement : MonoBehaviour
{
    public float speedY = 2.0f;
    public float speedX = 0.0f;
    private float mouseX = 0.0f;
    private float mouseY = 0.0f;
    void Update()
    {
        bool isPaused = EscapeMenu.GamePaused;
        float checkHealth = healthScript.healthTime;
        if(isPaused == false && checkHealth > 1)
        {
            mouseX += speedX * Input.GetAxis("Mouse X");
            mouseY = Mathf.Min(50, Mathf.Max(-50,
            mouseY -= speedY * Input.GetAxis("Mouse Y")));
            transform.eulerAngles = new Vector3(mouseY, mouseX, 0.0f);
        }
        
    }
}
