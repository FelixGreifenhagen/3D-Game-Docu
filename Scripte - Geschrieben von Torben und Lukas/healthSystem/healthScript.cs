using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthScript : MonoBehaviour
{
    public GameObject ozean;
    public GameObject gameOverScreen;
    public GameObject OneLife;
    public GameObject TwoLife;
    public GameObject ThreeLife;
    public GameObject FourLife;
    public GameObject FiveLife;
    public static float healthTime;
    bool touchesWater = false;
    public static bool gameIsOver;
    bool touchesCactus;
    bool touchesLava;
    private void Start()
    {
        healthTime = 6.0f;
        gameOverScreen.SetActive(false);
        gameIsOver = false;
        touchesCactus = false;
    }
    void Update()
    {
        print(healthTime);
        if(touchesLava == true)
        {
            healthTime -= 20;
        }
        if (touchesCactus == true || touchesWater == true)
        {
            healthTime -= Time.deltaTime;
        }
        if(healthTime >= 1)
        {
            OneLife.SetActive(true);
            if (healthTime >= 3)
            {
                TwoLife.SetActive(true);
                if (healthTime >= 5)
                {
                    ThreeLife.SetActive(true);
                    if(healthTime >= 6)
                    {
                        FourLife.SetActive(true);
                    }
                }
            }
        }
          if(healthTime < 5)
          {
              if (touchesWater == false && touchesCactus == false)
              {
                  //healthTime += Time.deltaTime;
              }
              FourLife.SetActive(false);
              if(healthTime <= 4)
              {
                  ThreeLife.SetActive(false);
                  if(healthTime <= 2)
                  {
                      TwoLife.SetActive(false);
                      if(healthTime <= 1)
                      {
                          OneLife.SetActive(false);
                          gameIsOver = true;
                          CursorScript.CursorLockedVar = false;
                          gameOverScreen.SetActive(true);
                          Time.timeScale = 0f;
                      }
                  }
              }
          } 
        
    }
    void OnCollisionEnter(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Ozean")
        {
            touchesWater = true;           
        }
        else
        {
            touchesWater = false;
        }
        if (theCollision.gameObject.name == "Kaktus")
        {
            touchesCactus = true;
        }
        else
        {
            touchesCactus = false;
        }
        if(theCollision.gameObject.name == "Lava")
        {
            touchesLava = true;
        }
        else
        {
            touchesLava = false;
        }
    }
    void OnCollisionExit(Collision theCollision)
    {
        if (theCollision.gameObject.name == "Ozean")
        {
            touchesWater = false;
        }
        if (theCollision.gameObject.name == "Kaktus")
        {
            touchesCactus = false;
        }
        if(theCollision.gameObject.name == "Lava")
        {
            touchesLava = false;
        }
    }
    public void mainScreen()
    {
        SceneManager.LoadScene("MainMenu");
    }
}




