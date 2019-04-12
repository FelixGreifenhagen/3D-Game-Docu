using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()       
    {
        bool isOver = healthScript.gameIsOver;

        if (Input.GetKeyDown(KeyCode.Escape) && isOver == false)
        {
            if(GamePaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;

        
        bool getCursorState = CursorScript.CursorLockedVar;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        getCursorState = true;
        CursorScript.CursorLockedVar = getCursorState;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Schliesse Spiel...");
        Application.Quit();
    }
    
}
