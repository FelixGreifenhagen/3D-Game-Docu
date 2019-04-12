using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crapMove : MonoBehaviour
{
    public Animator crap;
    public float timer;
    void Start()
    {
        crap = GetComponent<Animator>();
        crap.SetBool("crapMove", true);
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 40)
        {
            crap.SetBool("crapMove", false);
        }
    }
}
