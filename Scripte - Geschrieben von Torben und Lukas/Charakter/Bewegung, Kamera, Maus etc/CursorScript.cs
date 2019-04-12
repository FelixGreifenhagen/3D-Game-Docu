using UnityEngine;
using System.Collections;

public class CursorScript : MonoBehaviour
{
    public float checkHealth;
    public static bool CursorLockedVar;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        CursorLockedVar = true;
        
    }

    void Update()
    {
        checkHealth = healthScript.healthTime;
        bool isPaused = EscapeMenu.GamePaused;
        if (isPaused == false && checkHealth > 1)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            CursorLockedVar = true;
        }
        else if (isPaused == true || checkHealth < 1)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            CursorLockedVar = false;
        }
    }
}