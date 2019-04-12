using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackwards : MonoBehaviour
{
    public Animator move;
    void Start()
    {
        move = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            move.SetBool("MovingBackwards", true);
        }
        if (!Input.GetKey(KeyCode.S))
        {
            move.SetBool("MovingBackwards", false);
        }
    }
}
