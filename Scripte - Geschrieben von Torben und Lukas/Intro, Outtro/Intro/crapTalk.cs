using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crapTalk : MonoBehaviour
{
    public GameObject Talk1;
    public GameObject Talk2;
    public GameObject Talk3;
    public GameObject title;
    public float timer;
    void Start()
    {
        Talk1.SetActive(false);
        Talk2.SetActive(false);
        Talk3.SetActive(false);
        title.SetActive(false);
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 40)
        {
            title.SetActive(true);
            Talk1.SetActive(true);
            if(timer > 50)
            {
                Talk1.SetActive(false);
                Talk2.SetActive(true);
                if(timer > 60)
                {
                    Talk2.SetActive(false);
                    Talk3.SetActive(true);
                    if(timer == 70)
                    {
                        Talk3.SetActive(false);
                        title.SetActive(false);
                    }
                }                
            }
        }
    }
}
