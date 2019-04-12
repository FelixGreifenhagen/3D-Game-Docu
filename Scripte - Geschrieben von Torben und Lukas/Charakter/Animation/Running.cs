using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    public Animator move; 
    void Start()
    {
        move = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) {
            move.SetBool("Running", true);
        }
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            move.SetBool("Running", false);
        }
    }
}
