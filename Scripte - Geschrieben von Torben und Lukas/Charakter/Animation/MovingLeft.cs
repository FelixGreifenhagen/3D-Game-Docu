using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingLeft : MonoBehaviour
{
    public Animator move;
    void Start()
    {
        move = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            move.SetBool("MovingLeft", true);
        }
        if (!Input.GetKey(KeyCode.A))
        {
            move.SetBool("MovingLeft", false);
        }
    }
}
