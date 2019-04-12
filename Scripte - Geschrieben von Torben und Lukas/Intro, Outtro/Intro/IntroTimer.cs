using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroTimer : MonoBehaviour
{
    public float timer;
    void Start()
    {
        timer = 0.0f;
    }    
    void Update()
    {
        timer += Time.deltaTime;
        print(timer);
        if(timer > 70)
        {
            SceneManager.LoadScene("SampleScene");
        }

    }
}
