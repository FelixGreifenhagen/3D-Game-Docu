using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRight : MonoBehaviour
{
    public Animator move;
    void Start()
    {
        move = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            move.SetBool("MovingRight", true);
        }
        if (!Input.GetKey(KeyCode.D))
        {
            move.SetBool("MovingRight", false);
        }
    }
}
